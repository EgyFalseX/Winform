USE [Nestle]
GO
/****** Object:  StoredProcedure [dbo].[Pro_0001]    Script Date: 4/9/2014 3:32:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Actual KPI Vs target (salesman),,>
-- =============================================
ALTER PROCEDURE [dbo].[Pro_0001]
	-- Add the parameters for the stored procedure here
	@CurrentYearDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @CurrentYearFristDayInMonth date
	SET @CurrentYearFristDayInMonth = CAST(CAST(YEAR(@CurrentYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@CurrentYearDate) AS VARCHAR(2)) + '-01' AS date)

	DECLARE @CurrentYearYesterday date
	SET @CurrentYearYesterday =  DATEADD(DAY, -1, @CurrentYearDate)

	;WITH CTELvl1 
	AS
	(
		SELECT Count(DISTINCT BillingDocument) as BillingDocument, SUM(NPS) AS NPS, SUM(Quin) AS Quin, SUM(Cases) AS Cases, SUM(Volume) AS Volume, SoldToParty, RouteNumber, BillingDate
		FROM vBillContains
		WHERE (BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AND (ConditionTypeId <> 1)
		GROUP BY SoldToParty, RouteNumber, BillingDate
	),
	CTELvl2
	AS
	(
		SELECT        RouteNumber, CustomerId,
		(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) AS SalesDay,
		(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS SalesMonth,
		(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) AS APOSDay,
		(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS APOSMoth,
	
		IIF((SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) =
		 (SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate),
		 (SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate), 0) AS FirstAPOS,--IF (INVDAY = INVMONTH) THEN APOSDay ELSE 0

		(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) AS INVDay,
		(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS INVMoth
		FROM            RouteCustomer
		WHERE RouteCustomerStateId = 1
		GROUP BY RouteNumber, CustomerId
	)

	SELECT RouteNumber
	 ,(SELECT RouteName FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS RouteName
	 ,(SELECT Supervisor FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS Supervisor
	 ,(SELECT RouteBrand FROM RouteBrand WHERE RouteBrandId = (SELECT RouteBrandId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS RouteBrand
	 ,(SELECT PlantSalesDistrict FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS PlantSalesDistrict
	 ,(SELECT PlantName FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))) AS PlantName
	 ,(SELECT PlantBaseName FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)))) AS PlantBaseName
	 ,(SELECT DistributionChannel FROM DistributionChannel WHERE DistributionChannelId = (SELECT DistributionChannelId FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))))) AS DistributionChannel
	 ,(SELECT TargetSalesDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS SalesDayTarget, SUM(SalesDay) AS SalesDay
	 ,(SELECT TargetSalesMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS SalesMonthTarget, SUM(SalesMonth) AS SalesMonth
	 ,(SELECT TargetAPOSDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS APOSDayTarget, SUM(APOSDay) AS APOSDay
	 ,(SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS APOSMonthTarget, SUM(APOSMoth) AS APOSMoth
	 ,SUM(FirstAPOS) AS FirstAPOS
	 ,(SELECT TargetINVDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS INVDayTarget, SUM(INVDay) AS INVDay
	 ,(SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS INVMonthTarget, SUM(INVMoth) AS INVMoth
	 ,(SELECT TargetDSDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS DSDayTarget, ISNULL(SUM(SalesDay) / NULLIF(SUM(INVDay), 0), 0) AS DSDay
	 ,(SELECT TargetDSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS DSMonthTarget, ISNULL(SUM(SalesMonth) / NULLIF(SUM(INVMoth), 0), 0) AS DSMonth
	 ,ISNULL((SUM(INVMoth) *1.0) / NULLIF(SUM(APOSMoth), 0), 0) AS INV_POS
	 ,((SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) *1.0) / 
	  NULLIF((SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)), 0) AS INV_POSTarget
	FROM CTELvl2

	GROUP BY RouteNumber

END
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [Nestle]
GO
/****** Object:  StoredProcedure [dbo].[Pro_0002]    Script Date: 4/9/2014 3:32:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Actual KPI Vs Target,,>
-- =============================================
ALTER PROCEDURE [dbo].[Pro_0002]
	-- Add the parameters for the stored procedure here
	@CurrentYearDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @CurrentYearFristDayInMonth date
	SET @CurrentYearFristDayInMonth = CAST(CAST(YEAR(@CurrentYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@CurrentYearDate) AS VARCHAR(2)) + '-01' AS date)

	DECLARE @CurrentYearYesterday date
	SET @CurrentYearYesterday =  DATEADD(DAY, -1, @CurrentYearDate)

	;WITH CTELvl1 
	AS
	(
		SELECT Count(DISTINCT BillingDocument) as BillingDocument, SUM(NPS) AS NPS, SUM(Quin) AS Quin, SUM(Cases) AS Cases, SUM(Volume) AS Volume, SoldToParty, RouteNumber, BillingDate
		FROM vBillContains
		WHERE (BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AND (ConditionTypeId <> 1)
		GROUP BY SoldToParty, RouteNumber, BillingDate
	),
	CTELvl2
	AS
	(
		SELECT        RouteNumber, CustomerId,
			(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) AS APOSDay,
			(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS APOSMoth,
			(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) AS INVDay,
			(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS INVMoth,
			(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate = @CurrentYearDate) AS SalesDay,
			(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS SalesMonth
		FROM            RouteCustomer
		WHERE RouteCustomerStateId = 1
		GROUP BY RouteNumber, CustomerId
	)

	SELECT RouteNumber
		 ,(SELECT RouteName FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS RouteName
		 ,(SELECT Supervisor FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS Supervisor
		 ,(SELECT RouteBrand FROM RouteBrand WHERE RouteBrandId = (SELECT RouteBrandId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS RouteBrand
		 ,(SELECT PlantSalesDistrict FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS PlantSalesDistrict
		 ,(SELECT PlantName FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))) AS PlantName
		 ,(SELECT PlantBaseName FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)))) AS PlantBaseName
		 ,(SELECT DistributionChannel FROM DistributionChannel WHERE DistributionChannelId = (SELECT DistributionChannelId FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))))) AS DistributionChannel
		 ,SUM(APOSDay) AS APOSDay, (SELECT TargetAPOSDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS APOSDayTarget
		 ,SUM(APOSMoth) AS APOSMoth, (SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS APOSMonthTarget
		 ,SUM(INVDay) AS INVDay, (SELECT TargetINVDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS INVDayTarget
		 ,SUM(INVMoth) AS INVMoth, (SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS INVMonthTarget
		 ,SUM(SalesDay) AS SalesDay, (SELECT TargetSalesDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS SalesDayTarget
		 ,SUM(SalesMonth) AS SalesMonth, (SELECT TargetSalesMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS SalesMonthTarget
		 ,ISNULL(SUM(SalesDay) / NULLIF(SUM(INVDay), 0), 0) AS DSDay, (SELECT TargetDSDay FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS DSDayTarget
		 ,ISNULL(SUM(SalesMonth) / NULLIF(SUM(INVMoth), 0), 0) AS DSMonth, (SELECT TargetDSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS DSMonthTarget
	FROM CTELvl2
	GROUP BY RouteNumber

END
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [Nestle]
GO
/****** Object:  StoredProcedure [dbo].[Pro_0003]    Script Date: 4/9/2014 3:32:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Actual KPI Vs LY Vs Target MTD,,>
-- =============================================
ALTER PROCEDURE [dbo].[Pro_0003]
	-- Add the parameters for the stored procedure here
	@CurrentYearDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @CurrentYearFristDayInMonth date
	SET @CurrentYearFristDayInMonth = CAST(CAST(YEAR(@CurrentYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@CurrentYearDate) AS VARCHAR(2)) + '-01' AS date)

	DECLARE @CurrentYearYesterday date
	SET @CurrentYearYesterday =  DATEADD(DAY, -1, @CurrentYearDate)

	DECLARE @LastYearDate date
	SET @LastYearDate =  DATEADD(YEAR, -1, @CurrentYearDate)

	DECLARE @LastYearFristDayInMonth date
	SET @LastYearFristDayInMonth = CAST(CAST(YEAR(@LastYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@LastYearDate) AS VARCHAR(2)) + '-01' AS date)

	;WITH CTELvl1 
	AS
	(
		SELECT Count(DISTINCT BillingDocument) as BillingDocument, SUM(NPS) AS NPS, SUM(Quin) AS Quin, SUM(Cases) AS Cases, SUM(Volume) AS Volume, SoldToParty, RouteNumber, BillingDate
		FROM vBillContains
		WHERE  (BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate OR BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AND ConditionTypeId <> 1
		GROUP BY SoldToParty, RouteNumber, BillingDate
	),
	CTELvl2
	AS
	(
		SELECT        RouteNumber, CustomerId,
			(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS APOSMoth,
			(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AS APOSMothLY,
			(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS INVMoth,
			(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AS INVMothLY,
			(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS SalesMonth,
			(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AS SalesMonthLY
		FROM            RouteCustomer
		WHERE RouteCustomerStateId = 1
		GROUP BY RouteNumber, CustomerId
	)

	SELECT RouteNumber
		 ,(SELECT RouteName FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS RouteName
		 ,(SELECT Supervisor FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS Supervisor
		 ,(SELECT RouteBrand FROM RouteBrand WHERE RouteBrandId = (SELECT RouteBrandId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS RouteBrand
		 ,(SELECT PlantSalesDistrict FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS PlantSalesDistrict
		 ,(SELECT PlantName FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))) AS PlantName
		 ,(SELECT PlantBaseName FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)))) AS PlantBaseName
		 ,(SELECT DistributionChannel FROM DistributionChannel WHERE DistributionChannelId = (SELECT DistributionChannelId FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))))) AS DistributionChannel

		 ,SUM(APOSMoth) AS APOSMoth, SUM(APOSMothLY) AS APOSMothLY
		 ,(SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS APOSMonthTarget
		 ,(SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@LastYearDate) AND TargetMonth = MONTH(@LastYearDate)) AS APOSMonthTargetLY
		 
		 ,SUM(INVMoth) AS INVMoth, SUM(INVMothLY) AS INVMothLY
		 ,(SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS INVMonthTarget
		 ,(SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@LastYearDate) AND TargetMonth = MONTH(@LastYearDate)) AS INVMonthTargetLY
		 
		 ,SUM(SalesMonth) AS SalesMonth, SUM(SalesMonthLY) AS SalesMonthLY
		 ,(SELECT TargetSalesMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS SalesMonthTarget
		 ,(SELECT TargetSalesMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@LastYearDate) AND TargetMonth = MONTH(@LastYearDate)) AS SalesMonthTargetLY

		 ,(SUM(SalesMonth)*1.0) / NULLIF(SUM(INVMoth), 0) AS DSMonth
		 ,(SUM(SalesMonthLY)*1.0) / NULLIF(SUM(INVMothLY), 0) AS DSMonthLY
		 ,(SELECT TargetDSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS DSMonthTarget
		 
	FROM CTELvl2
	GROUP BY RouteNumber

END
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [Nestle]
GO
/****** Object:  StoredProcedure [dbo].[Pro_0004]    Script Date: 4/9/2014 3:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Zero Sales MTD,,>
-- =============================================
ALTER PROCEDURE [dbo].[Pro_0004]
	-- Add the parameters for the stored procedure here
	@CurrentYearDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @CurrentYearFristDayInMonth date
	SET @CurrentYearFristDayInMonth = CAST(CAST(YEAR(@CurrentYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@CurrentYearDate) AS VARCHAR(2)) + '-01' AS date)
	;WITH CTELvl1
	AS
	(
	SELECT RouteNumber, CustomerId
	,IIF((SELECT COUNT(SoldToParty) FROM vBillContains WHERE RouteNumber = RouteCustomer.RouteNumber AND SoldToParty = RouteCustomer.CustomerId AND
	BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) > 0, 'Active', 'Zero') AS Active
	,(SELECT COUNT(*) FROM Equipment WHERE FunctionalId = RouteCustomer.CustomerId  AND (BrandId = 1 OR BrandId = 2)) AS Equipment--AND (BrandId = 1 OR BrandId = 2)
	,(SELECT CustomerType FROM CustomerType WHERE CustomerTypeId = (SELECT CustomerTypeId FROM Customer WHERE CustomerId = RouteCustomer.CustomerId)) AS CustomerType
	,IIF((SELECT COUNT(*) FROM Equipment WHERE FunctionalId = RouteCustomer.CustomerId AND (BrandId = 1 OR BrandId = 2)) > 0, 'CIC' ,'PIC') AS CType
	FROM            RouteCustomer
	WHERE RouteCustomerStateId = 1
	GROUP BY RouteNumber, CustomerId
	),
	CTELvl2 
	AS
	(
		SELECT RouteNumber, Active, SUM(Equipment) Equipment, COUNT(CustomerId) AS ALLCustomer, CustomerType, CTYPE
		FROM            CTELvl1
		GROUP BY RouteNumber, Active, CustomerType, CType
	)
	
	SELECT RouteNumber, Active, Equipment, ALLCustomer, CustomerType, CType
	,(SELECT RouteName FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS RouteName
	,(SELECT Supervisor FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS Supervisor
	,(SELECT RouteBrand FROM RouteBrand WHERE RouteBrandId = (SELECT RouteBrandId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS RouteBrand
	,(SELECT PlantSalesDistrict FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS PlantSalesDistrict
	,(SELECT PlantName FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))) AS PlantName
	,(SELECT PlantBaseName FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)))) AS PlantBaseName
	,(SELECT DistributionChannel FROM DistributionChannel WHERE DistributionChannelId = (SELECT DistributionChannelId FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))))) AS DistributionChannel
	FROM            CTELvl2
END
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [Nestle]
GO
/****** Object:  StoredProcedure [dbo].[Pro_0005]    Script Date: 4/9/2014 3:33:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<KPI MTD,,>
-- =============================================
ALTER PROCEDURE [dbo].[Pro_0005]
	-- Add the parameters for the stored procedure here
	@CurrentYearDate date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @CurrentYearFristDayInMonth date
	SET @CurrentYearFristDayInMonth = CAST(CAST(YEAR(@CurrentYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@CurrentYearDate) AS VARCHAR(2)) + '-01' AS date)

	DECLARE @CurrentYearYesterday date
	SET @CurrentYearYesterday =  DATEADD(DAY, -1, @CurrentYearDate)

	DECLARE @LastYearDate date
	SET @LastYearDate =  DATEADD(YEAR, -1, @CurrentYearDate)

	DECLARE @LastYearFristDayInMonth date
	SET @LastYearFristDayInMonth = CAST(CAST(YEAR(@LastYearDate) AS VARCHAR(4)) + '-' + CAST(MONTH(@LastYearDate) AS VARCHAR(2)) + '-01' AS date)

	;WITH CTELvl1 
	AS
	(
		SELECT Count(DISTINCT BillingDocument) as BillingDocument, SUM(NPS) AS NPS, SUM(Quin) AS Quin, SUM(Cases) AS Cases, SUM(Volume) AS Volume, SoldToParty, RouteNumber, BillingDate
		FROM vBillContains
		WHERE  (BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate OR BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AND ConditionTypeId <> 1
		GROUP BY SoldToParty, RouteNumber, BillingDate
	),
	CTELvl2
	AS
	(
		SELECT        RouteNumber, CustomerId,
			(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS APOSMoth,
			(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AS APOSMothLY,
			(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS INVMoth,
			(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AS INVMothLY,
			(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentYearFristDayInMonth AND @CurrentYearDate) AS SalesMonth,
			(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastYearFristDayInMonth AND @LastYearDate) AS SalesMonthLY
		FROM            RouteCustomer
		WHERE RouteCustomerStateId = 1
		GROUP BY RouteNumber, CustomerId
	)

	SELECT RouteNumber
		 ,(SELECT RouteName FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS RouteName
		 ,(SELECT Supervisor FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS ASM
		 ,(SELECT ASM FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS Supervisor
		 ,(SELECT RouteBrand FROM RouteBrand WHERE RouteBrandId = (SELECT RouteBrandId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS RouteBrand
		 ,(SELECT PlantSalesDistrict FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS PlantSalesDistrict
		 ,(SELECT PlantName FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))) AS PlantName
		 ,(SELECT PlantBaseName FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)))) AS PlantBaseName
		 ,(SELECT DistributionChannel FROM DistributionChannel WHERE DistributionChannelId = (SELECT DistributionChannelId FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))))) AS DistributionChannel

		 ,SUM(APOSMoth) AS APOSMoth, SUM(APOSMothLY) AS APOSMothLY
		 ,(SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS APOSMonthTarget
		 ,(SELECT TargetAPOSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@LastYearDate) AND TargetMonth = MONTH(@LastYearDate)) AS APOSMonthTargetLY
		 
		 ,SUM(INVMoth) AS INVMoth, SUM(INVMothLY) AS INVMothLY
		 ,(SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS INVMonthTarget
		 ,(SELECT TargetINVMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@LastYearDate) AND TargetMonth = MONTH(@LastYearDate)) AS INVMonthTargetLY
		 
		 ,SUM(SalesMonth) AS SalesMonth, SUM(SalesMonthLY) AS SalesMonthLY
		 ,(SELECT TargetSalesMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS SalesMonthTarget
		 ,(SELECT TargetSalesMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@LastYearDate) AND TargetMonth = MONTH(@LastYearDate)) AS SalesMonthTargetLY

		 ,(SUM(SalesMonth)*1.0) / NULLIF(SUM(INVMoth), 0) AS DSMonth
		 ,(SUM(SalesMonthLY)*1.0) / NULLIF(SUM(INVMothLY), 0) AS DSMonthLY
		 ,(SELECT TargetDSMonth FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentYearDate) AND TargetMonth = MONTH(@CurrentYearDate)) AS DSMonthTarget
		 
	FROM CTELvl2
	GROUP BY RouteNumber

END
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
USE [Nestle]
GO
/****** Object:  StoredProcedure [dbo].[Pro_0006]    Script Date: 4/9/2014 3:33:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery7.sql|7|0|C:\Users\FalseX\AppData\Local\Temp\~vsE95C.sql
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<KPI Weekly,,>
-- =============================================
ALTER PROCEDURE [dbo].[Pro_0006]
	-- Add the parameters for the stored procedure here
	@CurrentDate DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @WeekNum INT = DATEPART(ISO_WEEK, @CurrentDate)
DECLARE @CurrentStartDate DATE = DATEADD(wk, DATEDIFF(wk, 6, '1/1/' + CAST(YEAR(@CurrentDate) AS varchar(4))) + (@WeekNum-1), 7)
DECLARE @CurrentEndDate DATE = DATEADD(wk, DATEDIFF(wk, 5, '1/1/' + CAST(YEAR(@CurrentDate) AS varchar(4))) + (@WeekNum-1), 6)

DECLARE @LastDate DATE = DATEADD(YEAR, -1, @CurrentDate)
DECLARE @LastWeekNum INT = DATEPART(ISO_WEEK, @LastDate)
DECLARE @LastStartDate DATE = DATEADD(wk, DATEDIFF(wk, 6, '1/1/' + CAST(YEAR(@LastDate) AS varchar(4))) + (@LastWeekNum-1), 7)
DECLARE @LastEndDate DATE = DATEADD(wk, DATEDIFF(wk, 5, '1/1/' + CAST(YEAR(@LastDate) AS varchar(4))) + (@LastWeekNum-1), 6)

;WITH CTELvl1 
AS
(
	SELECT Count(DISTINCT BillingDocument) as BillingDocument, SUM(NPS) AS NPS 
	,SoldToParty, RouteNumber, YEAR(BillingDate) AS DateYear, DATEPART(ISO_WEEK,BillingDate) AS DateWeek, BillingDate
	FROM vBillContains
	WHERE (BillingDate BETWEEN @CurrentStartDate AND @CurrentEndDate OR BillingDate BETWEEN @LastStartDate AND @LastEndDate) AND ConditionTypeId <> 1
	GROUP BY SoldToParty, RouteNumber, BillingDate
),
CTELvl2
AS
(
	SELECT        RouteNumber, CustomerId
		,(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentStartDate AND @CurrentEndDate) AS NPSWeek
		,(SELECT ISNULL(SUM(NPS), 0) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastStartDate AND @LastEndDate) AS NPSWeekLY

		,(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentStartDate AND @CurrentEndDate) AS APOSWeek
		,(SELECT COUNT(DISTINCT SoldToParty) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastStartDate AND @LastEndDate) AS APOSWeekLY
	
		,(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @CurrentStartDate AND @CurrentEndDate) AS INVWeek
		,(SELECT COUNT(BillingDocument) FROM CTELvl1 WHERE SoldToParty = RouteCustomer.CustomerId AND BillingDate BETWEEN @LastStartDate AND @LastEndDate) AS INVWeekLY

	FROM            RouteCustomer
	WHERE RouteCustomerStateId = 1
	GROUP BY RouteNumber, CustomerId
),
CTELvl3
AS
(
	SELECT RouteNumber, SUM(NPSWeek) AS NPSWeek, SUM(NPSWeekLY) AS NPSWeekLY, SUM(APOSWeek) AS APOSWeek, SUM(APOSWeekLY) AS APOSWeekLY, SUM(INVWeek) AS INVWeek, SUM(INVWeekLY) AS INVWeekLY
	,(SELECT RouteName FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS RouteName
	,(SELECT Supervisor FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS Supervisor
	,(SELECT ASM FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber) AS ASM
	,(SELECT RouteBrand FROM RouteBrand WHERE RouteBrandId = (SELECT RouteBrandId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS RouteBrand
	,(SELECT PlantSalesDistrict FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)) AS PlantSalesDistrict
	,(SELECT PlantName FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))) AS PlantName
	,(SELECT PlantBaseName FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber)))) AS PlantBaseName
	,(SELECT DistributionChannel FROM DistributionChannel WHERE DistributionChannelId = (SELECT DistributionChannelId FROM PlantBase WHERE PlantBaseId = (SELECT PlantBaseId FROM Plant WHERE PlantId = (SELECT PlantId FROM PlantSalesDistrict WHERE PlantSalesDistrictId = (SELECT PlantSalesDistrictId FROM Routes WHERE RouteNumber = CTELvl2.RouteNumber))))) AS DistributionChannel
	,(SELECT TargetSalesWeek FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentDate) AND TargetMonth = MONTH(@CurrentDate)) AS NPSWeekTarget
	,(SELECT TargetAPOSWeek FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentDate) AND TargetMonth = MONTH(@CurrentDate)) AS APOSWeekTarget
	,(SELECT TargetINVWeek FROM RouteTarget WHERE RouteNumber = CTELvl2.RouteNumber AND TargetYear = YEAR(@CurrentDate) AND TargetMonth = MONTH(@CurrentDate)) AS INVWeekTarget
	FROM CTELvl2
	GROUP BY RouteNumber
)
	
	SELECT RouteNumber, NPSWeek, NPSWeekLY, APOSWeek, APOSWeekLY, INVWeek, INVWeekLY, RouteName, Supervisor, ASM, RouteBrand, PlantSalesDistrict, PlantName, PlantBaseName, DistributionChannel
	,NPSWeekTarget, APOSWeekTarget, INVWeekTarget
	,(NPSWeek * 1.0) / NULLIF(INVWeek, 0) AS DSWeek
	,(NPSWeekLY * 1.0) / NULLIF(INVWeekLY, 0) AS DSWeekLY
	,(NPSWeekTarget * 1.0) / NULLIF(INVWeekTarget, 0) AS DSWeekTarget
	FROM CTELvl3
END
