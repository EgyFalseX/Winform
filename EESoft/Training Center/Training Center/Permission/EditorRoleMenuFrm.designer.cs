namespace Training_Center
{
    partial class EditorRoleMenuFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorRoleMenuFrm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LUEItems = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barMM = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.mbDBChange = new DevExpress.XtraBars.BarCheckItem();
            this.mbExit = new DevExpress.XtraBars.BarCheckItem();
            this.mCode = new DevExpress.XtraBars.BarSubItem();
            this.mbCdBankAccount = new DevExpress.XtraBars.BarCheckItem();
            this.mbCDCertificates = new DevExpress.XtraBars.BarCheckItem();
            this.mbCDCourseType = new DevExpress.XtraBars.BarCheckItem();
            this.mbCdjob = new DevExpress.XtraBars.BarCheckItem();
            this.mbCDknow = new DevExpress.XtraBars.BarCheckItem();
            this.mbCdLab = new DevExpress.XtraBars.BarCheckItem();
            this.mbCDMembershipType = new DevExpress.XtraBars.BarCheckItem();
            this.mbCdNationality = new DevExpress.XtraBars.BarCheckItem();
            this.mbCdPlace = new DevExpress.XtraBars.BarCheckItem();
            this.mbCDReservationWay = new DevExpress.XtraBars.BarCheckItem();
            this.mbCDTrainingBag = new DevExpress.XtraBars.BarCheckItem();
            this.mPermission = new DevExpress.XtraBars.BarSubItem();
            this.mbUsers = new DevExpress.XtraBars.BarCheckItem();
            this.mbUserRoles = new DevExpress.XtraBars.BarCheckItem();
            this.mbRoles = new DevExpress.XtraBars.BarCheckItem();
            this.mHelp = new DevExpress.XtraBars.BarSubItem();
            this.mbAbout = new DevExpress.XtraBars.BarCheckItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.sSecMsg = new DevExpress.XtraBars.BarStaticItem();
            this.mPaintStyle = new DevExpress.XtraBars.BarSubItem();
            this.mOldStyles = new DevExpress.XtraBars.BarSubItem();
            this.iWXP = new DevExpress.XtraBars.BarCheckItem();
            this.iOffXP = new DevExpress.XtraBars.BarCheckItem();
            this.iOff2K = new DevExpress.XtraBars.BarCheckItem();
            this.iOff2003 = new DevExpress.XtraBars.BarCheckItem();
            this.iDefault = new DevExpress.XtraBars.BarCheckItem();
            this.mOfficeSkins = new DevExpress.XtraBars.BarSubItem();
            this.mBonusSkins = new DevExpress.XtraBars.BarSubItem();
            this.sItem = new DevExpress.XtraBars.BarButtonItem();
            this.mbRoleDetial = new DevExpress.XtraBars.BarCheckItem();
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(165, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اختر سماحيه";
            // 
            // LUEItems
            // 
            this.LUEItems.Location = new System.Drawing.Point(12, 28);
            this.LUEItems.Name = "LUEItems";
            this.LUEItems.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEItems.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleName", "Role Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoleDesc", "Description")});
            this.LUEItems.Properties.NullText = "";
            this.LUEItems.Size = new System.Drawing.Size(147, 19);
            this.LUEItems.TabIndex = 0;
            this.LUEItems.EditValueChanged += new System.EventHandler(this.LUEItems_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LUEItems);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(22, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(253, 59);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "جميع السماحيات";
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "تغير قاعدة البيانات";
            this.barCheckItem1.Id = 61;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMM});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.mHelp,
            this.sSecMsg,
            this.mPaintStyle,
            this.mOldStyles,
            this.mOfficeSkins,
            this.mBonusSkins,
            this.iWXP,
            this.iOffXP,
            this.iOff2K,
            this.iOff2003,
            this.iDefault,
            this.mCode,
            this.sItem,
            this.mbExit,
            this.mbCdBankAccount,
            this.mbCDCertificates,
            this.mbCDCourseType,
            this.mbCdjob,
            this.mbCDknow,
            this.mbCdLab,
            this.mbCDMembershipType,
            this.mbCdNationality,
            this.mbCdPlace,
            this.mbCDReservationWay,
            this.mbCDTrainingBag,
            this.mbAbout,
            this.mbDBChange,
            this.mPermission,
            this.mbUsers,
            this.mbRoles,
            this.mbRoleDetial,
            this.mbUserRoles});
            this.barManager.MainMenu = this.barMM;
            this.barManager.MaxItemId = 66;
            this.barManager.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Never;
            // 
            // barMM
            // 
            this.barMM.BarName = "Main menu";
            this.barMM.DockCol = 0;
            this.barMM.DockRow = 0;
            this.barMM.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.barMM.FloatLocation = new System.Drawing.Point(400, 298);
            this.barMM.FloatSize = new System.Drawing.Size(191, 29);
            this.barMM.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mCode),
            new DevExpress.XtraBars.LinkPersistInfo(this.mPermission),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHelp)});
            this.barMM.OptionsBar.MultiLine = true;
            this.barMM.OptionsBar.UseWholeRow = true;
            this.barMM.Text = "Main menu";
            this.barMM.Visible = false;
            // 
            // mFile
            // 
            this.mFile.Caption = "ملف";
            this.mFile.Id = 0;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mbDBChange),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbExit)});
            this.mFile.Name = "mFile";
            // 
            // mbDBChange
            // 
            this.mbDBChange.Caption = "تغير قاعدة البيانات";
            this.mbDBChange.Id = 60;
            this.mbDBChange.Name = "mbDBChange";
            this.mbDBChange.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbExit
            // 
            this.mbExit.Caption = "خروج";
            this.mbExit.Id = 46;
            this.mbExit.Name = "mbExit";
            this.mbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mCode
            // 
            this.mCode.Caption = "الاكواد";
            this.mCode.Id = 32;
            this.mCode.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCdBankAccount),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCDCertificates),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCDCourseType),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCdjob),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCDknow),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCdLab),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCDMembershipType),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCdNationality),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCdPlace),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCDReservationWay),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbCDTrainingBag)});
            this.mCode.Name = "mCode";
            // 
            // mbCdBankAccount
            // 
            this.mbCdBankAccount.Caption = "حسابات البنك";
            this.mbCdBankAccount.Id = 48;
            this.mbCdBankAccount.ImageIndex = 4;
            this.mbCdBankAccount.Name = "mbCdBankAccount";
            this.mbCdBankAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCDCertificates
            // 
            this.mbCDCertificates.Caption = "الشهادات";
            this.mbCDCertificates.Id = 49;
            this.mbCDCertificates.ImageIndex = 5;
            this.mbCDCertificates.Name = "mbCDCertificates";
            this.mbCDCertificates.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCDCourseType
            // 
            this.mbCDCourseType.Caption = "فئات الدورات التدريبية";
            this.mbCDCourseType.Id = 50;
            this.mbCDCourseType.ImageIndex = 6;
            this.mbCDCourseType.Name = "mbCDCourseType";
            this.mbCDCourseType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCdjob
            // 
            this.mbCdjob.Caption = "اكواد الوظائف";
            this.mbCdjob.Id = 51;
            this.mbCdjob.ImageIndex = 7;
            this.mbCdjob.Name = "mbCdjob";
            this.mbCdjob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCDknow
            // 
            this.mbCDknow.Caption = "طرق التعرف على الاكاديمية";
            this.mbCDknow.Id = 52;
            this.mbCDknow.ImageIndex = 8;
            this.mbCDknow.Name = "mbCDknow";
            this.mbCDknow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCdLab
            // 
            this.mbCdLab.Caption = "القاعات التدريبية";
            this.mbCdLab.Id = 53;
            this.mbCdLab.ImageIndex = 9;
            this.mbCdLab.Name = "mbCdLab";
            this.mbCdLab.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCDMembershipType
            // 
            this.mbCDMembershipType.Caption = "انواع الاشتراكات";
            this.mbCDMembershipType.Id = 54;
            this.mbCDMembershipType.ImageIndex = 10;
            this.mbCDMembershipType.Name = "mbCDMembershipType";
            this.mbCDMembershipType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCdNationality
            // 
            this.mbCdNationality.Caption = "الجنسية";
            this.mbCdNationality.Id = 55;
            this.mbCdNationality.ImageIndex = 11;
            this.mbCdNationality.Name = "mbCdNationality";
            this.mbCdNationality.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCdPlace
            // 
            this.mbCdPlace.Caption = "اماكن الدورات";
            this.mbCdPlace.Id = 56;
            this.mbCdPlace.ImageIndex = 12;
            this.mbCdPlace.Name = "mbCdPlace";
            this.mbCdPlace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCDReservationWay
            // 
            this.mbCDReservationWay.Caption = "طرق الحجز";
            this.mbCDReservationWay.Id = 57;
            this.mbCDReservationWay.ImageIndex = 13;
            this.mbCDReservationWay.Name = "mbCDReservationWay";
            this.mbCDReservationWay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbCDTrainingBag
            // 
            this.mbCDTrainingBag.Caption = "الحقائب التدريبية";
            this.mbCDTrainingBag.Id = 58;
            this.mbCDTrainingBag.ImageIndex = 14;
            this.mbCDTrainingBag.Name = "mbCDTrainingBag";
            this.mbCDTrainingBag.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mPermission
            // 
            this.mPermission.Caption = "الصلاحيات";
            this.mPermission.Id = 61;
            this.mPermission.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mbUsers),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbUserRoles),
            new DevExpress.XtraBars.LinkPersistInfo(this.mbRoles)});
            this.mPermission.Name = "mPermission";
            // 
            // mbUsers
            // 
            this.mbUsers.Caption = "المستخدمين";
            this.mbUsers.Id = 62;
            this.mbUsers.Name = "mbUsers";
            this.mbUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbUserRoles
            // 
            this.mbUserRoles.Caption = "صلاحيات المستخدمين";
            this.mbUserRoles.Id = 65;
            this.mbUserRoles.Name = "mbUserRoles";
            this.mbUserRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mbRoles
            // 
            this.mbRoles.Caption = "الصلاحيات";
            this.mbRoles.Id = 63;
            this.mbRoles.Name = "mbRoles";
            this.mbRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // mHelp
            // 
            this.mHelp.Caption = "مساعده";
            this.mHelp.Id = 1;
            this.mHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mbAbout)});
            this.mHelp.Name = "mHelp";
            // 
            // mbAbout
            // 
            this.mbAbout.Caption = "عن البرنامج";
            this.mbAbout.Id = 59;
            this.mbAbout.Name = "mbAbout";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(275, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 274);
            this.barDockControlBottom.Size = new System.Drawing.Size(275, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(22, 274);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(275, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 274);
            // 
            // sSecMsg
            // 
            this.sSecMsg.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.sSecMsg.Caption = "... جاهز";
            this.sSecMsg.Id = 10;
            this.sSecMsg.Name = "sSecMsg";
            this.sSecMsg.TextAlignment = System.Drawing.StringAlignment.Far;
            this.sSecMsg.Width = 32;
            // 
            // mPaintStyle
            // 
            this.mPaintStyle.Caption = "Paint Style";
            this.mPaintStyle.Id = 21;
            this.mPaintStyle.Name = "mPaintStyle";
            // 
            // mOldStyles
            // 
            this.mOldStyles.Caption = "Old Styles";
            this.mOldStyles.Id = 22;
            this.mOldStyles.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iWXP),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOffXP),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOff2K),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOff2003),
            new DevExpress.XtraBars.LinkPersistInfo(this.iDefault)});
            this.mOldStyles.Name = "mOldStyles";
            // 
            // iWXP
            // 
            this.iWXP.Caption = "WindowsXP";
            this.iWXP.Description = "WindowsXP";
            this.iWXP.Id = 25;
            this.iWXP.Name = "iWXP";
            // 
            // iOffXP
            // 
            this.iOffXP.Caption = "OfficeXP";
            this.iOffXP.Description = "OfficeXP";
            this.iOffXP.Id = 26;
            this.iOffXP.Name = "iOffXP";
            // 
            // iOff2K
            // 
            this.iOff2K.Caption = "Office2000";
            this.iOff2K.Description = "Office2000";
            this.iOff2K.Id = 27;
            this.iOff2K.Name = "iOff2K";
            // 
            // iOff2003
            // 
            this.iOff2003.Caption = "Office2003";
            this.iOff2003.Description = "Office2003";
            this.iOff2003.Id = 28;
            this.iOff2003.Name = "iOff2003";
            // 
            // iDefault
            // 
            this.iDefault.Caption = "Default";
            this.iDefault.Description = "Default";
            this.iDefault.Id = 29;
            this.iDefault.Name = "iDefault";
            // 
            // mOfficeSkins
            // 
            this.mOfficeSkins.Caption = "Office Skins";
            this.mOfficeSkins.Id = 23;
            this.mOfficeSkins.Name = "mOfficeSkins";
            // 
            // mBonusSkins
            // 
            this.mBonusSkins.Caption = "Bonus Skins";
            this.mBonusSkins.Id = 24;
            this.mBonusSkins.Name = "mBonusSkins";
            // 
            // sItem
            // 
            this.sItem.Caption = "ارشيف الرسائل";
            this.sItem.Id = 45;
            this.sItem.Name = "sItem";
            // 
            // mbRoleDetial
            // 
            this.mbRoleDetial.Caption = "تفاصيل الصلاحيات";
            this.mbRoleDetial.Id = 64;
            this.mbRoleDetial.Name = "mbRoleDetial";
            this.mbRoleDetial.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.mb_CheckedChanged);
            // 
            // EditorRoleMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 274);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditorRoleMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محتويات السماحيات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditorRoleMenuFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUEItems.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEItems;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barMM;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarCheckItem mbDBChange;
        private DevExpress.XtraBars.BarCheckItem mbExit;
        private DevExpress.XtraBars.BarSubItem mCode;
        private DevExpress.XtraBars.BarCheckItem mbCdBankAccount;
        private DevExpress.XtraBars.BarCheckItem mbCDCertificates;
        private DevExpress.XtraBars.BarCheckItem mbCDCourseType;
        private DevExpress.XtraBars.BarCheckItem mbCdjob;
        private DevExpress.XtraBars.BarCheckItem mbCDknow;
        private DevExpress.XtraBars.BarCheckItem mbCdLab;
        private DevExpress.XtraBars.BarCheckItem mbCDMembershipType;
        private DevExpress.XtraBars.BarCheckItem mbCdNationality;
        private DevExpress.XtraBars.BarCheckItem mbCdPlace;
        private DevExpress.XtraBars.BarCheckItem mbCDReservationWay;
        private DevExpress.XtraBars.BarCheckItem mbCDTrainingBag;
        private DevExpress.XtraBars.BarSubItem mPermission;
        private DevExpress.XtraBars.BarCheckItem mbUsers;
        private DevExpress.XtraBars.BarCheckItem mbRoles;
        private DevExpress.XtraBars.BarCheckItem mbRoleDetial;
        private DevExpress.XtraBars.BarCheckItem mbUserRoles;
        private DevExpress.XtraBars.BarSubItem mHelp;
        private DevExpress.XtraBars.BarCheckItem mbAbout;
        public DevExpress.XtraBars.BarStaticItem sSecMsg;
        private DevExpress.XtraBars.BarButtonItem sItem;
        private DevExpress.XtraBars.BarSubItem mPaintStyle;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mOldStyles;
        private DevExpress.XtraBars.BarCheckItem iWXP;
        private DevExpress.XtraBars.BarCheckItem iOffXP;
        private DevExpress.XtraBars.BarCheckItem iOff2K;
        private DevExpress.XtraBars.BarCheckItem iOff2003;
        private DevExpress.XtraBars.BarCheckItem iDefault;
        private DevExpress.XtraBars.BarSubItem mOfficeSkins;
        private DevExpress.XtraBars.BarSubItem mBonusSkins;

    }
}