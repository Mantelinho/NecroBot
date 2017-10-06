﻿namespace RocketBot2.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPosition = new System.Windows.Forms.TabPage();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.FindAdressBtn = new System.Windows.Forms.Button();
            this.ResetLocationBtn = new System.Windows.Forms.Button();
            this.gMapCtrl = new GMap.NET.WindowsForms.GMapControl();
            this.tabDevice = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.FirmwareTypeTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.FirmwareFingerprintTb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.deviceTypeCb = new System.Windows.Forms.ComboBox();
            this.RandomDeviceBtn = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.deviceIdlb = new System.Windows.Forms.Label();
            this.RandomIDBtn = new System.Windows.Forms.Button();
            this.DeviceIdTb = new System.Windows.Forms.TextBox();
            this.BoardName = new System.Windows.Forms.Label();
            this.AndroidBoardNameTb = new System.Windows.Forms.TextBox();
            this.FirmwareBrandTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HardwareManufacturerTb = new System.Windows.Forms.TextBox();
            this.HardwareModelTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DeviceModelBootTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DeviceModelIdentifierTb = new System.Windows.Forms.TextBox();
            this.FirmwareTagsTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeviceModelTb = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DeviceBrandTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AndroidBootloaderTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabAPIConfig = new System.Windows.Forms.TabPage();
            this.tbHashURL = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.tbPushBulletAPIKey = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.cbEnablePushBulletNotification = new System.Windows.Forms.CheckBox();
            this.cbDiplayHashServerLog = new System.Windows.Forms.CheckBox();
            this.cbUseCustomAPI = new System.Windows.Forms.CheckBox();
            this.tbAuthAPIKey = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.cbUsePogoDevAPI = new System.Windows.Forms.CheckBox();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.lvAccounts = new System.Windows.Forms.ListView();
            this.chAuthType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GoogleApiBox = new System.Windows.Forms.TextBox();
            this.GoogleApiLabel = new System.Windows.Forms.Label();
            this.tbWalkingSpeed = new System.Windows.Forms.TextBox();
            this.TravelSpeedText = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.proxyGb = new System.Windows.Forms.GroupBox();
            this.proxyPortTb = new System.Windows.Forms.TextBox();
            this.proxyUserTb = new System.Windows.Forms.TextBox();
            this.proxyPwTb = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.proxyHostTb = new System.Windows.Forms.TextBox();
            this.useProxyAuthCb = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.useProxyCb = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.UserLoginBox = new System.Windows.Forms.TextBox();
            this.UserPasswordBox = new System.Windows.Forms.TextBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.authTypeLabel = new System.Windows.Forms.Label();
            this.longiLabel = new System.Windows.Forms.Label();
            this.authTypeCb = new System.Windows.Forms.ComboBox();
            this.latLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.tabPokemon = new System.Windows.Forms.TabPage();
            this.tcPokemonDetail = new System.Windows.Forms.TabControl();
            this.tabCatch = new System.Windows.Forms.TabPage();
            this.cbUseLimitedEggIncubators = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbUseBerriesOperator = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.tbUseBerriesMinCp = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.tbUseBerriesMinIv = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tbUseBerriesBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox25 = new System.Windows.Forms.GroupBox();
            this.tbUseMasterBallBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.tbUseMasterBallAboveCp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBox23 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUseGreatBallAboveIv = new System.Windows.Forms.TextBox();
            this.tbUseGreatBallAboveCp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tbUseGreatBallBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.groupBox24 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUseUltraBallAboveCp = new System.Windows.Forms.TextBox();
            this.tbUseUltraBallBelowCatchProbability = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbUseUltraBallAboveIv = new System.Windows.Forms.TextBox();
            this.gbCatchIgnore = new System.Windows.Forms.GroupBox();
            this.clbCatchIgnore = new System.Windows.Forms.CheckedListBox();
            this.cbIgnoreAll = new System.Windows.Forms.CheckBox();
            this.cbUseEggIncubators = new System.Windows.Forms.CheckBox();
            this.cbCatchPoke = new System.Windows.Forms.CheckBox();
            this.gbCatchPokemon = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbAutoFavoriteShinyOnCatch = new System.Windows.Forms.CheckBox();
            this.tBMaxBerriesToUsePerPokemon = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.cbAutoFavoritePokemon = new System.Windows.Forms.CheckBox();
            this.tbMaxPokeballsPerPokemon = new System.Windows.Forms.TextBox();
            this.tbFavoriteMinIvPercentage = new System.Windows.Forms.TextBox();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbTransferDuplicatePokemonOnCapture = new System.Windows.Forms.CheckBox();
            this.cbTransferDuplicatePokemon = new System.Windows.Forms.CheckBox();
            this.cbTransferWeakPokemon = new System.Windows.Forms.CheckBox();
            this.tbKeepMinDuplicatePokemon = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cbPrioritizeIvOverCp = new System.Windows.Forms.CheckBox();
            this.tbKeepMinIV = new System.Windows.Forms.TextBox();
            this.cbKeepMinOperator = new System.Windows.Forms.ComboBox();
            this.tbKeepMinCp = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.gbExcludeTrans = new System.Windows.Forms.GroupBox();
            this.clbTransfer = new System.Windows.Forms.CheckedListBox();
            this.cbNotTransferAll = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbKeepPokemonsToBeEvolved = new System.Windows.Forms.CheckBox();
            this.tbKeepMinLvl = new System.Windows.Forms.TextBox();
            this.cbUseKeepMinLvl = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tabPowerUp = new System.Windows.Forms.TabPage();
            this.cbPowerUpFav = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbPowerUpMinIV = new System.Windows.Forms.TextBox();
            this.cbPowerUpCondiction = new System.Windows.Forms.ComboBox();
            this.tbPowerUpMinCP = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cbPowerUpMinStarDust = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cbPowerUpType = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.gbPUP = new System.Windows.Forms.GroupBox();
            this.clbPowerUp = new System.Windows.Forms.CheckedListBox();
            this.cbPowerUpAll = new System.Windows.Forms.CheckBox();
            this.cbAutoPowerUp = new System.Windows.Forms.CheckBox();
            this.tabEvo = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.tbEvolveApplyLuckyEggOnEvolutionCountValue = new System.Windows.Forms.TextBox();
            this.cbEvolveApplyLuckyEggOnEvolutionCount = new System.Windows.Forms.CheckBox();
            this.cbEvolvePreserveMinCandiesFromFilter = new System.Windows.Forms.CheckBox();
            this.cbEvolveAll = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEvolvePokemonsThatMatchFilter = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cbEvolveAnyPokemonAboveIv = new System.Windows.Forms.CheckBox();
            this.tbEvolveAnyPokemonAboveIvValue = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTriggerEvolveIfLuckyEggIsActive = new System.Windows.Forms.CheckBox();
            this.tbTriggerEvolveOnStorageUsageAbsoluteValue = new System.Windows.Forms.TextBox();
            this.cbTriggerEvolveOnStorageUsageAbsolute = new System.Windows.Forms.CheckBox();
            this.tbTriggerEvolveOnStorageUsagePercentageValue = new System.Windows.Forms.TextBox();
            this.tbTriggerEvolveOnEvolutionCountValue = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbTriggerEvolveAsSoonAsFilterIsMatched = new System.Windows.Forms.CheckBox();
            this.cbTriggerEvolveOnEvolutionCount = new System.Windows.Forms.CheckBox();
            this.cbTriggerEvolveOnStorageUsagePercentage = new System.Windows.Forms.CheckBox();
            this.gbEvolve = new System.Windows.Forms.GroupBox();
            this.clbEvolve = new System.Windows.Forms.CheckedListBox();
            this.tabSnipePokemonFilter = new System.Windows.Forms.TabPage();
            this.gbSnipe = new System.Windows.Forms.GroupBox();
            this.clbSnipePokemonFilter = new System.Windows.Forms.CheckedListBox();
            this.cbSnipePokemonFilterAll = new System.Windows.Forms.CheckBox();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.cbUseIncenseConstantly = new System.Windows.Forms.CheckBox();
            this.cbUseLuckyEggConstantly = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cbVerboseRecycling = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRecycleInventoryAtUsagePercentage = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfPokeballsToKeep = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfPotionsToKeep = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfRevivesToKeep = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.tbTotalAmountOfBerriesToKeep = new System.Windows.Forms.TextBox();
            this.tabAdvSetting = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.tbCatchFleeCount = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.cbSelectAccountOnStartUp = new System.Windows.Forms.CheckBox();
            this.cbDisplayList = new System.Windows.Forms.CheckBox();
            this.tbPokestopSoftbanCount = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.cbStartFromDefaultLocation = new System.Windows.Forms.CheckBox();
            this.label73 = new System.Windows.Forms.Label();
            this.tbEXPSwitch = new System.Windows.Forms.TextBox();
            this.tbPokestopSwitch = new System.Windows.Forms.TextBox();
            this.tbPokemonPerHourSwitch = new System.Windows.Forms.TextBox();
            this.tbPokemonSwitch = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.tbMinIVToSwitch = new System.Windows.Forms.TextBox();
            this.cbOnRarePokemon = new System.Windows.Forms.CheckBox();
            this.label69 = new System.Windows.Forms.Label();
            this.tbRuntimeSwitch = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.tbRuntimeSwitchRandomTime = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tbOnLimitPauseTimes = new System.Windows.Forms.TextBox();
            this.cbSwitchOnPokestopLimit = new System.Windows.Forms.CheckBox();
            this.cbSwitchOnCatchLimit = new System.Windows.Forms.CheckBox();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label32 = new System.Windows.Forms.Label();
            this.tbAutoWalkKM = new System.Windows.Forms.TextBox();
            this.cbAutoWalkAI = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cbRandomizeRecycle = new System.Windows.Forms.CheckBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tbRandomRecycleValue = new System.Windows.Forms.TextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.tbWalkingSpeedVariantInKilometerPerHour = new System.Windows.Forms.TextBox();
            this.cbStartFromLastPosition = new System.Windows.Forms.CheckBox();
            this.cbShowWalkingSpeed = new System.Windows.Forms.CheckBox();
            this.cbUseWalkingSpeedVariant = new System.Windows.Forms.CheckBox();
            this.cbDisableHumanWalking = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tbMaxSpawnLocationOffset = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.tbMaxTravelDistanceInMeters = new System.Windows.Forms.TextBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.cbUseHumanlikeDelays = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.tbDelayBetweenPlayerActions = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tbDelayBetweenPokemonCatch = new System.Windows.Forms.TextBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.cbEnableHumanizedThrows = new System.Windows.Forms.CheckBox();
            this.tbForceExcellentThrowOverCp = new System.Windows.Forms.TextBox();
            this.tbForceGreatThrowOverCp = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.tbForceExcellentThrowOverIv = new System.Windows.Forms.TextBox();
            this.tbNiceThrowChance = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.tbForceGreatThrowOverIv = new System.Windows.Forms.TextBox();
            this.tbGreatThrowChance = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tbCurveThrowChance = new System.Windows.Forms.TextBox();
            this.tbExcellentThrowChance = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.tabAuthJson = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.Auth = new System.Windows.Forms.TreeView();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.Config = new System.Windows.Forms.TreeView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cbAutoSniper = new System.Windows.Forms.CheckBox();
            this.cbEnableGyms = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.tbDataServiceIdentification = new System.Windows.Forms.TextBox();
            this.cbEnableSyncData = new System.Windows.Forms.CheckBox();
            this.cBoxTeamColor = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tabDevice.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tabAPIConfig.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.proxyGb.SuspendLayout();
            this.tabPokemon.SuspendLayout();
            this.tcPokemonDetail.SuspendLayout();
            this.tabCatch.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox25.SuspendLayout();
            this.groupBox23.SuspendLayout();
            this.groupBox24.SuspendLayout();
            this.gbCatchIgnore.SuspendLayout();
            this.gbCatchPokemon.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbExcludeTrans.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPowerUp.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbPUP.SuspendLayout();
            this.tabEvo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbEvolve.SuspendLayout();
            this.tabSnipePokemonFilter.SuspendLayout();
            this.gbSnipe.SuspendLayout();
            this.tabItems.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabAdvSetting.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.tabAuthJson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(660, 416);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 50);
            this.cancelBtn.TabIndex = 31;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabAuth);
            this.tabControl.Controls.Add(this.tabPokemon);
            this.tabControl.Controls.Add(this.tabItems);
            this.tabControl.Controls.Add(this.tabAdvSetting);
            this.tabControl.Controls.Add(this.tabAuthJson);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(770, 414);
            this.tabControl.TabIndex = 30;
            // 
            // tabAuth
            // 
            this.tabAuth.BackColor = System.Drawing.SystemColors.Control;
            this.tabAuth.Controls.Add(this.tabControl1);
            this.tabAuth.Controls.Add(this.GoogleApiBox);
            this.tabAuth.Controls.Add(this.GoogleApiLabel);
            this.tabAuth.Controls.Add(this.tbWalkingSpeed);
            this.tabAuth.Controls.Add(this.TravelSpeedText);
            this.tabAuth.Controls.Add(this.cbLanguage);
            this.tabAuth.Controls.Add(this.label26);
            this.tabAuth.Controls.Add(this.proxyGb);
            this.tabAuth.Controls.Add(this.UserLoginBox);
            this.tabAuth.Controls.Add(this.UserPasswordBox);
            this.tabAuth.Controls.Add(this.tbLatitude);
            this.tabAuth.Controls.Add(this.tbLongitude);
            this.tabAuth.Controls.Add(this.authTypeLabel);
            this.tabAuth.Controls.Add(this.longiLabel);
            this.tabAuth.Controls.Add(this.authTypeCb);
            this.tabAuth.Controls.Add(this.latLabel);
            this.tabAuth.Controls.Add(this.UserLabel);
            this.tabAuth.Controls.Add(this.PasswordLabel);
            this.tabAuth.Location = new System.Drawing.Point(4, 24);
            this.tabAuth.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabAuth.Size = new System.Drawing.Size(762, 386);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "Auth";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPosition);
            this.tabControl1.Controls.Add(this.tabDevice);
            this.tabControl1.Controls.Add(this.tabAPIConfig);
            this.tabControl1.Controls.Add(this.tabAccounts);
            this.tabControl1.Location = new System.Drawing.Point(270, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 382);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPosition
            // 
            this.tabPosition.BackColor = System.Drawing.SystemColors.Control;
            this.tabPosition.Controls.Add(this.AdressBox);
            this.tabPosition.Controls.Add(this.trackBar);
            this.tabPosition.Controls.Add(this.FindAdressBtn);
            this.tabPosition.Controls.Add(this.ResetLocationBtn);
            this.tabPosition.Controls.Add(this.gMapCtrl);
            this.tabPosition.Location = new System.Drawing.Point(4, 24);
            this.tabPosition.Margin = new System.Windows.Forms.Padding(2);
            this.tabPosition.Name = "tabPosition";
            this.tabPosition.Padding = new System.Windows.Forms.Padding(2);
            this.tabPosition.Size = new System.Drawing.Size(482, 354);
            this.tabPosition.TabIndex = 0;
            this.tabPosition.Text = "Position";
            // 
            // AdressBox
            // 
            this.AdressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressBox.ForeColor = System.Drawing.Color.Gray;
            this.AdressBox.Location = new System.Drawing.Point(7, 326);
            this.AdressBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(266, 23);
            this.AdressBox.TabIndex = 25;
            this.AdressBox.Text = "Enter an address or a coordinate";
            this.AdressBox.Enter += new System.EventHandler(this.AdressBox_Enter);
            this.AdressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdressBox_KeyPress);
            this.AdressBox.Leave += new System.EventHandler(this.AdressBox_Leave);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.BackColor = System.Drawing.SystemColors.Info;
            this.trackBar.Location = new System.Drawing.Point(444, -8);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.trackBar.Maximum = 18;
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 150);
            this.trackBar.TabIndex = 25;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar.Value = 2;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // FindAdressBtn
            // 
            this.FindAdressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindAdressBtn.Location = new System.Drawing.Point(277, 323);
            this.FindAdressBtn.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.FindAdressBtn.Name = "FindAdressBtn";
            this.FindAdressBtn.Size = new System.Drawing.Size(100, 30);
            this.FindAdressBtn.TabIndex = 25;
            this.FindAdressBtn.Text = "Find Location";
            this.FindAdressBtn.UseVisualStyleBackColor = true;
            this.FindAdressBtn.Click += new System.EventHandler(this.FindAdressBtn_Click);
            // 
            // ResetLocationBtn
            // 
            this.ResetLocationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetLocationBtn.Location = new System.Drawing.Point(382, 323);
            this.ResetLocationBtn.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.ResetLocationBtn.Name = "ResetLocationBtn";
            this.ResetLocationBtn.Size = new System.Drawing.Size(100, 30);
            this.ResetLocationBtn.TabIndex = 26;
            this.ResetLocationBtn.Text = "Reset Location";
            this.ResetLocationBtn.UseVisualStyleBackColor = true;
            this.ResetLocationBtn.Click += new System.EventHandler(this.ResetLocationBtn_Click);
            // 
            // gMapCtrl
            // 
            this.gMapCtrl.BackColor = System.Drawing.SystemColors.Info;
            this.gMapCtrl.Bearing = 0F;
            this.gMapCtrl.CanDragMap = true;
            this.gMapCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapCtrl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapCtrl.GrayScaleMode = false;
            this.gMapCtrl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapCtrl.LevelsKeepInMemmory = 5;
            this.gMapCtrl.Location = new System.Drawing.Point(2, 2);
            this.gMapCtrl.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.gMapCtrl.MarkersEnabled = true;
            this.gMapCtrl.MaxZoom = 18;
            this.gMapCtrl.MinZoom = 2;
            this.gMapCtrl.MouseWheelZoomEnabled = true;
            this.gMapCtrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;
            this.gMapCtrl.Name = "gMapCtrl";
            this.gMapCtrl.NegativeMode = false;
            this.gMapCtrl.PolygonsEnabled = true;
            this.gMapCtrl.RetryLoadTile = 0;
            this.gMapCtrl.RoutesEnabled = true;
            this.gMapCtrl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapCtrl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapCtrl.ShowTileGridLines = false;
            this.gMapCtrl.Size = new System.Drawing.Size(478, 350);
            this.gMapCtrl.TabIndex = 22;
            this.gMapCtrl.Zoom = 0D;
            this.gMapCtrl.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.GMapCtrl_OnMapZoomChanged);
            this.gMapCtrl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GMapCtrl_MouseClick);
            this.gMapCtrl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GMapCtrl_MouseUp);
            // 
            // tabDevice
            // 
            this.tabDevice.BackColor = System.Drawing.SystemColors.Control;
            this.tabDevice.Controls.Add(this.groupBox20);
            this.tabDevice.Controls.Add(this.label22);
            this.tabDevice.Controls.Add(this.label18);
            this.tabDevice.Controls.Add(this.deviceTypeCb);
            this.tabDevice.Controls.Add(this.RandomDeviceBtn);
            this.tabDevice.Controls.Add(this.label20);
            this.tabDevice.Controls.Add(this.label21);
            this.tabDevice.Controls.Add(this.deviceIdlb);
            this.tabDevice.Controls.Add(this.RandomIDBtn);
            this.tabDevice.Controls.Add(this.DeviceIdTb);
            this.tabDevice.Controls.Add(this.BoardName);
            this.tabDevice.Controls.Add(this.AndroidBoardNameTb);
            this.tabDevice.Controls.Add(this.FirmwareBrandTb);
            this.tabDevice.Controls.Add(this.label9);
            this.tabDevice.Controls.Add(this.label11);
            this.tabDevice.Controls.Add(this.HardwareManufacturerTb);
            this.tabDevice.Controls.Add(this.HardwareModelTb);
            this.tabDevice.Controls.Add(this.label10);
            this.tabDevice.Controls.Add(this.DeviceModelBootTb);
            this.tabDevice.Controls.Add(this.label8);
            this.tabDevice.Controls.Add(this.label12);
            this.tabDevice.Controls.Add(this.DeviceModelIdentifierTb);
            this.tabDevice.Controls.Add(this.FirmwareTagsTb);
            this.tabDevice.Controls.Add(this.label7);
            this.tabDevice.Controls.Add(this.DeviceModelTb);
            this.tabDevice.Controls.Add(this.label15);
            this.tabDevice.Controls.Add(this.DeviceBrandTb);
            this.tabDevice.Controls.Add(this.label16);
            this.tabDevice.Controls.Add(this.AndroidBootloaderTb);
            this.tabDevice.Controls.Add(this.label17);
            this.tabDevice.Location = new System.Drawing.Point(4, 24);
            this.tabDevice.Margin = new System.Windows.Forms.Padding(2);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.Padding = new System.Windows.Forms.Padding(2);
            this.tabDevice.Size = new System.Drawing.Size(482, 354);
            this.tabDevice.TabIndex = 1;
            this.tabDevice.Text = "Device";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.FirmwareTypeTb);
            this.groupBox20.Controls.Add(this.label13);
            this.groupBox20.Controls.Add(this.label14);
            this.groupBox20.Controls.Add(this.FirmwareFingerprintTb);
            this.groupBox20.Location = new System.Drawing.Point(242, 186);
            this.groupBox20.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox20.Size = new System.Drawing.Size(226, 76);
            this.groupBox20.TabIndex = 70;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Firmware";
            // 
            // FirmwareTypeTb
            // 
            this.FirmwareTypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirmwareTypeTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareTypeTb.Location = new System.Drawing.Point(42, 20);
            this.FirmwareTypeTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FirmwareTypeTb.Name = "FirmwareTypeTb";
            this.FirmwareTypeTb.Size = new System.Drawing.Size(172, 23);
            this.FirmwareTypeTb.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "Type";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.Location = new System.Drawing.Point(6, 50);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "Fingerprint";
            // 
            // FirmwareFingerprintTb
            // 
            this.FirmwareFingerprintTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirmwareFingerprintTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareFingerprintTb.Location = new System.Drawing.Point(74, 46);
            this.FirmwareFingerprintTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FirmwareFingerprintTb.Name = "FirmwareFingerprintTb";
            this.FirmwareFingerprintTb.Size = new System.Drawing.Size(142, 23);
            this.FirmwareFingerprintTb.TabIndex = 62;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(248, 282);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(227, 60);
            this.label22.TabIndex = 69;
            this.label22.Text = "This setting change what the server\r\nthink you are using to play Pokémon GO. \r\nIt" +
    "s a good idea to change your device to \r\nwhat phone you are using to prevent ban" +
    ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 16);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "Device Type:";
            // 
            // deviceTypeCb
            // 
            this.deviceTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceTypeCb.FormattingEnabled = true;
            this.deviceTypeCb.Items.AddRange(new object[] {
            "Apple",
            "Android"});
            this.deviceTypeCb.Location = new System.Drawing.Point(150, 12);
            this.deviceTypeCb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deviceTypeCb.Name = "deviceTypeCb";
            this.deviceTypeCb.Size = new System.Drawing.Size(86, 23);
            this.deviceTypeCb.TabIndex = 37;
            this.deviceTypeCb.SelectionChangeCommitted += new System.EventHandler(this.DeviceTypeCb_SelectionChangeCommitted);
            // 
            // RandomDeviceBtn
            // 
            this.RandomDeviceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomDeviceBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RandomDeviceBtn.Location = new System.Drawing.Point(149, 282);
            this.RandomDeviceBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RandomDeviceBtn.Name = "RandomDeviceBtn";
            this.RandomDeviceBtn.Size = new System.Drawing.Size(86, 60);
            this.RandomDeviceBtn.TabIndex = 64;
            this.RandomDeviceBtn.Text = "I am feeling RICH (Randomize)";
            this.RandomDeviceBtn.UseVisualStyleBackColor = true;
            this.RandomDeviceBtn.Click += new System.EventHandler(this.RandomDeviceBtn_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(6, 260);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 67;
            this.label20.Text = "Important:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 282);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 60);
            this.label21.TabIndex = 66;
            this.label21.Text = "For your account safety.\r\nPlease do not change\r\nyour device infomation\r\ntoo often" +
    ".\r\n";
            // 
            // deviceIdlb
            // 
            this.deviceIdlb.AutoSize = true;
            this.deviceIdlb.Location = new System.Drawing.Point(6, 42);
            this.deviceIdlb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deviceIdlb.Name = "deviceIdlb";
            this.deviceIdlb.Size = new System.Drawing.Size(56, 15);
            this.deviceIdlb.TabIndex = 45;
            this.deviceIdlb.Text = "Device ID";
            // 
            // RandomIDBtn
            // 
            this.RandomIDBtn.Location = new System.Drawing.Point(66, 38);
            this.RandomIDBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.RandomIDBtn.Name = "RandomIDBtn";
            this.RandomIDBtn.Size = new System.Drawing.Size(80, 22);
            this.RandomIDBtn.TabIndex = 65;
            this.RandomIDBtn.Text = "Get New ID";
            this.RandomIDBtn.UseVisualStyleBackColor = true;
            this.RandomIDBtn.Click += new System.EventHandler(this.RandomIDBtn_Click);
            // 
            // DeviceIdTb
            // 
            this.DeviceIdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceIdTb.Location = new System.Drawing.Point(150, 38);
            this.DeviceIdTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DeviceIdTb.Name = "DeviceIdTb";
            this.DeviceIdTb.Size = new System.Drawing.Size(86, 23);
            this.DeviceIdTb.TabIndex = 38;
            // 
            // BoardName
            // 
            this.BoardName.AutoSize = true;
            this.BoardName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BoardName.Location = new System.Drawing.Point(6, 66);
            this.BoardName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BoardName.Name = "BoardName";
            this.BoardName.Size = new System.Drawing.Size(119, 15);
            this.BoardName.TabIndex = 39;
            this.BoardName.Text = "Android Board Name";
            // 
            // AndroidBoardNameTb
            // 
            this.AndroidBoardNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AndroidBoardNameTb.Location = new System.Drawing.Point(150, 62);
            this.AndroidBoardNameTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AndroidBoardNameTb.Name = "AndroidBoardNameTb";
            this.AndroidBoardNameTb.Size = new System.Drawing.Size(86, 23);
            this.AndroidBoardNameTb.TabIndex = 61;
            // 
            // FirmwareBrandTb
            // 
            this.FirmwareBrandTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareBrandTb.Location = new System.Drawing.Point(220, 358);
            this.FirmwareBrandTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FirmwareBrandTb.Name = "FirmwareBrandTb";
            this.FirmwareBrandTb.Size = new System.Drawing.Size(240, 23);
            this.FirmwareBrandTb.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(6, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Hardware Manu facturer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(6, 360);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "Firmware Brand";
            // 
            // HardwareManufacturerTb
            // 
            this.HardwareManufacturerTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HardwareManufacturerTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HardwareManufacturerTb.Location = new System.Drawing.Point(150, 212);
            this.HardwareManufacturerTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.HardwareManufacturerTb.Name = "HardwareManufacturerTb";
            this.HardwareManufacturerTb.Size = new System.Drawing.Size(86, 23);
            this.HardwareManufacturerTb.TabIndex = 60;
            // 
            // HardwareModelTb
            // 
            this.HardwareModelTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HardwareModelTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HardwareModelTb.Location = new System.Drawing.Point(150, 238);
            this.HardwareModelTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.HardwareModelTb.Name = "HardwareModelTb";
            this.HardwareModelTb.Size = new System.Drawing.Size(86, 23);
            this.HardwareModelTb.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(6, 242);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Hardware Model";
            // 
            // DeviceModelBootTb
            // 
            this.DeviceModelBootTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceModelBootTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceModelBootTb.Location = new System.Drawing.Point(150, 186);
            this.DeviceModelBootTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DeviceModelBootTb.Name = "DeviceModelBootTb";
            this.DeviceModelBootTb.Size = new System.Drawing.Size(86, 23);
            this.DeviceModelBootTb.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Device Model Boot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(6, 394);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Firmware Tags";
            // 
            // DeviceModelIdentifierTb
            // 
            this.DeviceModelIdentifierTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceModelIdentifierTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceModelIdentifierTb.Location = new System.Drawing.Point(150, 162);
            this.DeviceModelIdentifierTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DeviceModelIdentifierTb.Name = "DeviceModelIdentifierTb";
            this.DeviceModelIdentifierTb.Size = new System.Drawing.Size(86, 23);
            this.DeviceModelIdentifierTb.TabIndex = 53;
            // 
            // FirmwareTagsTb
            // 
            this.FirmwareTagsTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FirmwareTagsTb.Location = new System.Drawing.Point(220, 392);
            this.FirmwareTagsTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.FirmwareTagsTb.Name = "FirmwareTagsTb";
            this.FirmwareTagsTb.Size = new System.Drawing.Size(240, 23);
            this.FirmwareTagsTb.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Device Model Identifier";
            // 
            // DeviceModelTb
            // 
            this.DeviceModelTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceModelTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceModelTb.Location = new System.Drawing.Point(150, 138);
            this.DeviceModelTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DeviceModelTb.Name = "DeviceModelTb";
            this.DeviceModelTb.Size = new System.Drawing.Size(86, 23);
            this.DeviceModelTb.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.Location = new System.Drawing.Point(6, 142);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 42;
            this.label15.Text = "Device Model";
            // 
            // DeviceBrandTb
            // 
            this.DeviceBrandTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceBrandTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeviceBrandTb.Location = new System.Drawing.Point(150, 112);
            this.DeviceBrandTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.DeviceBrandTb.Name = "DeviceBrandTb";
            this.DeviceBrandTb.Size = new System.Drawing.Size(86, 23);
            this.DeviceBrandTb.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.Location = new System.Drawing.Point(6, 116);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 15);
            this.label16.TabIndex = 41;
            this.label16.Text = "Device Brand";
            // 
            // AndroidBootloaderTb
            // 
            this.AndroidBootloaderTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AndroidBootloaderTb.Location = new System.Drawing.Point(150, 86);
            this.AndroidBootloaderTb.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.AndroidBootloaderTb.Name = "AndroidBootloaderTb";
            this.AndroidBootloaderTb.Size = new System.Drawing.Size(86, 23);
            this.AndroidBootloaderTb.TabIndex = 59;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(6, 90);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 15);
            this.label17.TabIndex = 40;
            this.label17.Text = "Android Boot loader";
            // 
            // tabAPIConfig
            // 
            this.tabAPIConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tabAPIConfig.Controls.Add(this.tbHashURL);
            this.tabAPIConfig.Controls.Add(this.label74);
            this.tabAPIConfig.Controls.Add(this.tbPushBulletAPIKey);
            this.tabAPIConfig.Controls.Add(this.label68);
            this.tabAPIConfig.Controls.Add(this.cbEnablePushBulletNotification);
            this.tabAPIConfig.Controls.Add(this.cbDiplayHashServerLog);
            this.tabAPIConfig.Controls.Add(this.cbUseCustomAPI);
            this.tabAPIConfig.Controls.Add(this.tbAuthAPIKey);
            this.tabAPIConfig.Controls.Add(this.label67);
            this.tabAPIConfig.Controls.Add(this.cbUsePogoDevAPI);
            this.tabAPIConfig.Location = new System.Drawing.Point(4, 24);
            this.tabAPIConfig.Margin = new System.Windows.Forms.Padding(2);
            this.tabAPIConfig.Name = "tabAPIConfig";
            this.tabAPIConfig.Padding = new System.Windows.Forms.Padding(2);
            this.tabAPIConfig.Size = new System.Drawing.Size(482, 354);
            this.tabAPIConfig.TabIndex = 2;
            this.tabAPIConfig.Text = "APIConfig";
            // 
            // tbHashURL
            // 
            this.tbHashURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHashURL.Location = new System.Drawing.Point(87, 93);
            this.tbHashURL.Margin = new System.Windows.Forms.Padding(2);
            this.tbHashURL.Name = "tbHashURL";
            this.tbHashURL.Size = new System.Drawing.Size(150, 23);
            this.tbHashURL.TabIndex = 44;
            // 
            // label74
            // 
            this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(2, 95);
            this.label74.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(61, 15);
            this.label74.TabIndex = 43;
            this.label74.Text = "Hash URL:";
            // 
            // tbPushBulletAPIKey
            // 
            this.tbPushBulletAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPushBulletAPIKey.Location = new System.Drawing.Point(87, 167);
            this.tbPushBulletAPIKey.Margin = new System.Windows.Forms.Padding(2);
            this.tbPushBulletAPIKey.Name = "tbPushBulletAPIKey";
            this.tbPushBulletAPIKey.Size = new System.Drawing.Size(150, 23);
            this.tbPushBulletAPIKey.TabIndex = 42;
            // 
            // label68
            // 
            this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(2, 170);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(67, 15);
            this.label68.TabIndex = 41;
            this.label68.Text = "PB API Key:";
            // 
            // cbEnablePushBulletNotification
            // 
            this.cbEnablePushBulletNotification.AutoSize = true;
            this.cbEnablePushBulletNotification.Location = new System.Drawing.Point(6, 116);
            this.cbEnablePushBulletNotification.Margin = new System.Windows.Forms.Padding(2);
            this.cbEnablePushBulletNotification.Name = "cbEnablePushBulletNotification";
            this.cbEnablePushBulletNotification.Size = new System.Drawing.Size(186, 19);
            this.cbEnablePushBulletNotification.TabIndex = 40;
            this.cbEnablePushBulletNotification.Text = "Enable PushBullet Notification";
            this.cbEnablePushBulletNotification.UseVisualStyleBackColor = true;
            this.cbEnablePushBulletNotification.CheckedChanged += new System.EventHandler(this.CbEnablePushBulletNotification_CheckedChanged);
            // 
            // cbDiplayHashServerLog
            // 
            this.cbDiplayHashServerLog.AutoSize = true;
            this.cbDiplayHashServerLog.Location = new System.Drawing.Point(6, 90);
            this.cbDiplayHashServerLog.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiplayHashServerLog.Name = "cbDiplayHashServerLog";
            this.cbDiplayHashServerLog.Size = new System.Drawing.Size(147, 19);
            this.cbDiplayHashServerLog.TabIndex = 39;
            this.cbDiplayHashServerLog.Text = "Diplay Hash Server Log";
            this.cbDiplayHashServerLog.UseVisualStyleBackColor = true;
            // 
            // cbUseCustomAPI
            // 
            this.cbUseCustomAPI.AutoSize = true;
            this.cbUseCustomAPI.Location = new System.Drawing.Point(6, 40);
            this.cbUseCustomAPI.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseCustomAPI.Name = "cbUseCustomAPI";
            this.cbUseCustomAPI.Size = new System.Drawing.Size(111, 19);
            this.cbUseCustomAPI.TabIndex = 38;
            this.cbUseCustomAPI.Text = "Use Custom API";
            this.cbUseCustomAPI.UseVisualStyleBackColor = true;
            this.cbUseCustomAPI.CheckedChanged += new System.EventHandler(this.CbUseLegacyAPI_CheckedChanged);
            // 
            // tbAuthAPIKey
            // 
            this.tbAuthAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthAPIKey.Location = new System.Drawing.Point(87, 193);
            this.tbAuthAPIKey.Margin = new System.Windows.Forms.Padding(2);
            this.tbAuthAPIKey.Name = "tbAuthAPIKey";
            this.tbAuthAPIKey.Size = new System.Drawing.Size(150, 23);
            this.tbAuthAPIKey.TabIndex = 37;
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(2, 195);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(79, 15);
            this.label67.TabIndex = 36;
            this.label67.Text = "Auth API Key:";
            // 
            // cbUsePogoDevAPI
            // 
            this.cbUsePogoDevAPI.AutoSize = true;
            this.cbUsePogoDevAPI.Location = new System.Drawing.Point(6, 14);
            this.cbUsePogoDevAPI.Margin = new System.Windows.Forms.Padding(2);
            this.cbUsePogoDevAPI.Name = "cbUsePogoDevAPI";
            this.cbUsePogoDevAPI.Size = new System.Drawing.Size(117, 19);
            this.cbUsePogoDevAPI.TabIndex = 34;
            this.cbUsePogoDevAPI.Text = "Use PogoDev API";
            this.cbUsePogoDevAPI.UseVisualStyleBackColor = true;
            this.cbUsePogoDevAPI.CheckedChanged += new System.EventHandler(this.CbUsePogoDevAPI_CheckedChanged);
            // 
            // tabAccounts
            // 
            this.tabAccounts.BackColor = System.Drawing.SystemColors.Control;
            this.tabAccounts.Controls.Add(this.lvAccounts);
            this.tabAccounts.Location = new System.Drawing.Point(4, 24);
            this.tabAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(2);
            this.tabAccounts.Size = new System.Drawing.Size(482, 354);
            this.tabAccounts.TabIndex = 3;
            this.tabAccounts.Text = "Accounts";
            // 
            // lvAccounts
            // 
            this.lvAccounts.CheckBoxes = true;
            this.lvAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAuthType,
            this.chEmail,
            this.chUsername});
            this.lvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAccounts.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.Location = new System.Drawing.Point(2, 2);
            this.lvAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new System.Drawing.Size(478, 350);
            this.lvAccounts.TabIndex = 3;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = System.Windows.Forms.View.Details;
            // 
            // chAuthType
            // 
            this.chAuthType.Text = "Auth Type";
            this.chAuthType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAuthType.Width = 75;
            // 
            // chEmail
            // 
            this.chEmail.Text = "Email";
            this.chEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmail.Width = 250;
            // 
            // chUsername
            // 
            this.chUsername.Text = "Username";
            this.chUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chUsername.Width = 130;
            // 
            // GoogleApiBox
            // 
            this.GoogleApiBox.Location = new System.Drawing.Point(100, 112);
            this.GoogleApiBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.GoogleApiBox.Name = "GoogleApiBox";
            this.GoogleApiBox.Size = new System.Drawing.Size(164, 23);
            this.GoogleApiBox.TabIndex = 33;
            // 
            // GoogleApiLabel
            // 
            this.GoogleApiLabel.AutoSize = true;
            this.GoogleApiLabel.Location = new System.Drawing.Point(6, 114);
            this.GoogleApiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoogleApiLabel.Name = "GoogleApiLabel";
            this.GoogleApiLabel.Size = new System.Drawing.Size(91, 15);
            this.GoogleApiLabel.TabIndex = 32;
            this.GoogleApiLabel.Text = "Google API Key:";
            // 
            // tbWalkingSpeed
            // 
            this.tbWalkingSpeed.Location = new System.Drawing.Point(138, 186);
            this.tbWalkingSpeed.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbWalkingSpeed.Name = "tbWalkingSpeed";
            this.tbWalkingSpeed.Size = new System.Drawing.Size(126, 23);
            this.tbWalkingSpeed.TabIndex = 30;
            // 
            // TravelSpeedText
            // 
            this.TravelSpeedText.AutoSize = true;
            this.TravelSpeedText.Location = new System.Drawing.Point(6, 190);
            this.TravelSpeedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TravelSpeedText.Name = "TravelSpeedText";
            this.TravelSpeedText.Size = new System.Drawing.Size(131, 15);
            this.TravelSpeedText.TabIndex = 31;
            this.TravelSpeedText.Text = "Walking Speed (KM/H):";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(100, 10);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(164, 23);
            this.cbLanguage.TabIndex = 29;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 14);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(62, 15);
            this.label26.TabIndex = 28;
            this.label26.Text = "Language:";
            // 
            // proxyGb
            // 
            this.proxyGb.Controls.Add(this.proxyPortTb);
            this.proxyGb.Controls.Add(this.proxyUserTb);
            this.proxyGb.Controls.Add(this.proxyPwTb);
            this.proxyGb.Controls.Add(this.label24);
            this.proxyGb.Controls.Add(this.label25);
            this.proxyGb.Controls.Add(this.proxyHostTb);
            this.proxyGb.Controls.Add(this.useProxyAuthCb);
            this.proxyGb.Controls.Add(this.label19);
            this.proxyGb.Controls.Add(this.useProxyCb);
            this.proxyGb.Controls.Add(this.label23);
            this.proxyGb.Location = new System.Drawing.Point(4, 214);
            this.proxyGb.Margin = new System.Windows.Forms.Padding(2);
            this.proxyGb.Name = "proxyGb";
            this.proxyGb.Padding = new System.Windows.Forms.Padding(2);
            this.proxyGb.Size = new System.Drawing.Size(266, 162);
            this.proxyGb.TabIndex = 27;
            this.proxyGb.TabStop = false;
            this.proxyGb.Text = "Proxy Setting";
            // 
            // proxyPortTb
            // 
            this.proxyPortTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyPortTb.Location = new System.Drawing.Point(96, 62);
            this.proxyPortTb.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.proxyPortTb.Name = "proxyPortTb";
            this.proxyPortTb.Size = new System.Drawing.Size(162, 23);
            this.proxyPortTb.TabIndex = 36;
            // 
            // proxyUserTb
            // 
            this.proxyUserTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyUserTb.Location = new System.Drawing.Point(96, 108);
            this.proxyUserTb.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.proxyUserTb.Name = "proxyUserTb";
            this.proxyUserTb.Size = new System.Drawing.Size(162, 23);
            this.proxyUserTb.TabIndex = 34;
            // 
            // proxyPwTb
            // 
            this.proxyPwTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyPwTb.Location = new System.Drawing.Point(96, 134);
            this.proxyPwTb.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.proxyPwTb.Name = "proxyPwTb";
            this.proxyPwTb.PasswordChar = '*';
            this.proxyPwTb.Size = new System.Drawing.Size(162, 23);
            this.proxyPwTb.TabIndex = 35;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(26, 110);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 15);
            this.label24.TabIndex = 32;
            this.label24.Text = "Username:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(30, 134);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 15);
            this.label25.TabIndex = 33;
            this.label25.Text = "Password:";
            // 
            // proxyHostTb
            // 
            this.proxyHostTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proxyHostTb.Location = new System.Drawing.Point(96, 38);
            this.proxyHostTb.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.proxyHostTb.Name = "proxyHostTb";
            this.proxyHostTb.Size = new System.Drawing.Size(162, 23);
            this.proxyHostTb.TabIndex = 30;
            // 
            // useProxyAuthCb
            // 
            this.useProxyAuthCb.AutoSize = true;
            this.useProxyAuthCb.Location = new System.Drawing.Point(6, 86);
            this.useProxyAuthCb.Margin = new System.Windows.Forms.Padding(2);
            this.useProxyAuthCb.Name = "useProxyAuthCb";
            this.useProxyAuthCb.Size = new System.Drawing.Size(159, 19);
            this.useProxyAuthCb.TabIndex = 29;
            this.useProxyAuthCb.Text = "Use Proxy Authentication";
            this.useProxyAuthCb.UseVisualStyleBackColor = true;
            this.useProxyAuthCb.CheckedChanged += new System.EventHandler(this.UseProxyAuthCb_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(54, 40);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 15);
            this.label19.TabIndex = 28;
            this.label19.Text = "Host:";
            // 
            // useProxyCb
            // 
            this.useProxyCb.AutoSize = true;
            this.useProxyCb.Location = new System.Drawing.Point(6, 20);
            this.useProxyCb.Margin = new System.Windows.Forms.Padding(2);
            this.useProxyCb.Name = "useProxyCb";
            this.useProxyCb.Size = new System.Drawing.Size(77, 19);
            this.useProxyCb.TabIndex = 30;
            this.useProxyCb.Text = "Use Proxy\r\n";
            this.useProxyCb.UseVisualStyleBackColor = true;
            this.useProxyCb.CheckedChanged += new System.EventHandler(this.UseProxyCb_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(58, 66);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 15);
            this.label23.TabIndex = 29;
            this.label23.Text = "Port:";
            // 
            // UserLoginBox
            // 
            this.UserLoginBox.Location = new System.Drawing.Point(100, 62);
            this.UserLoginBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.UserLoginBox.Name = "UserLoginBox";
            this.UserLoginBox.Size = new System.Drawing.Size(164, 23);
            this.UserLoginBox.TabIndex = 11;
            // 
            // UserPasswordBox
            // 
            this.UserPasswordBox.Location = new System.Drawing.Point(100, 86);
            this.UserPasswordBox.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.UserPasswordBox.Name = "UserPasswordBox";
            this.UserPasswordBox.PasswordChar = '*';
            this.UserPasswordBox.Size = new System.Drawing.Size(164, 23);
            this.UserPasswordBox.TabIndex = 12;
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(100, 138);
            this.tbLatitude.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(164, 23);
            this.tbLatitude.TabIndex = 13;
            this.tbLatitude.Leave += new System.EventHandler(this.LatitudeText_Leave);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(100, 162);
            this.tbLongitude.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(164, 23);
            this.tbLongitude.TabIndex = 14;
            this.tbLongitude.Leave += new System.EventHandler(this.LongitudeText_Leave);
            // 
            // authTypeLabel
            // 
            this.authTypeLabel.AutoSize = true;
            this.authTypeLabel.Location = new System.Drawing.Point(6, 38);
            this.authTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authTypeLabel.Name = "authTypeLabel";
            this.authTypeLabel.Size = new System.Drawing.Size(68, 15);
            this.authTypeLabel.TabIndex = 0;
            this.authTypeLabel.Text = "Login Type:";
            // 
            // longiLabel
            // 
            this.longiLabel.AutoSize = true;
            this.longiLabel.Location = new System.Drawing.Point(6, 164);
            this.longiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.longiLabel.Name = "longiLabel";
            this.longiLabel.Size = new System.Drawing.Size(64, 15);
            this.longiLabel.TabIndex = 5;
            this.longiLabel.Text = "Longitude:";
            // 
            // authTypeCb
            // 
            this.authTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authTypeCb.FormattingEnabled = true;
            this.authTypeCb.Items.AddRange(new object[] {
            "Google",
            "PTC"});
            this.authTypeCb.Location = new System.Drawing.Point(100, 36);
            this.authTypeCb.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.authTypeCb.Name = "authTypeCb";
            this.authTypeCb.Size = new System.Drawing.Size(164, 23);
            this.authTypeCb.TabIndex = 1;
            // 
            // latLabel
            // 
            this.latLabel.AutoSize = true;
            this.latLabel.Location = new System.Drawing.Point(6, 138);
            this.latLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latLabel.Name = "latLabel";
            this.latLabel.Size = new System.Drawing.Size(53, 15);
            this.latLabel.TabIndex = 4;
            this.latLabel.Text = "Latitude:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(6, 64);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(63, 15);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 90);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // tabPokemon
            // 
            this.tabPokemon.BackColor = System.Drawing.SystemColors.Control;
            this.tabPokemon.Controls.Add(this.tcPokemonDetail);
            this.tabPokemon.Location = new System.Drawing.Point(4, 24);
            this.tabPokemon.Margin = new System.Windows.Forms.Padding(2);
            this.tabPokemon.Name = "tabPokemon";
            this.tabPokemon.Size = new System.Drawing.Size(762, 386);
            this.tabPokemon.TabIndex = 3;
            this.tabPokemon.Text = "Pokemon";
            // 
            // tcPokemonDetail
            // 
            this.tcPokemonDetail.Controls.Add(this.tabCatch);
            this.tcPokemonDetail.Controls.Add(this.tabTransfer);
            this.tcPokemonDetail.Controls.Add(this.tabPowerUp);
            this.tcPokemonDetail.Controls.Add(this.tabEvo);
            this.tcPokemonDetail.Controls.Add(this.tabSnipePokemonFilter);
            this.tcPokemonDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPokemonDetail.Location = new System.Drawing.Point(0, 0);
            this.tcPokemonDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tcPokemonDetail.Name = "tcPokemonDetail";
            this.tcPokemonDetail.SelectedIndex = 0;
            this.tcPokemonDetail.Size = new System.Drawing.Size(762, 386);
            this.tcPokemonDetail.TabIndex = 5;
            // 
            // tabCatch
            // 
            this.tabCatch.BackColor = System.Drawing.SystemColors.Control;
            this.tabCatch.Controls.Add(this.cbUseLimitedEggIncubators);
            this.tabCatch.Controls.Add(this.groupBox10);
            this.tabCatch.Controls.Add(this.groupBox9);
            this.tabCatch.Controls.Add(this.gbCatchIgnore);
            this.tabCatch.Controls.Add(this.cbUseEggIncubators);
            this.tabCatch.Controls.Add(this.cbCatchPoke);
            this.tabCatch.Controls.Add(this.gbCatchPokemon);
            this.tabCatch.Location = new System.Drawing.Point(4, 24);
            this.tabCatch.Margin = new System.Windows.Forms.Padding(2);
            this.tabCatch.Name = "tabCatch";
            this.tabCatch.Padding = new System.Windows.Forms.Padding(2);
            this.tabCatch.Size = new System.Drawing.Size(754, 358);
            this.tabCatch.TabIndex = 0;
            this.tabCatch.Text = "Catch";
            // 
            // cbUseLimitedEggIncubators
            // 
            this.cbUseLimitedEggIncubators.AutoSize = true;
            this.cbUseLimitedEggIncubators.Enabled = false;
            this.cbUseLimitedEggIncubators.Location = new System.Drawing.Point(126, 6);
            this.cbUseLimitedEggIncubators.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseLimitedEggIncubators.Name = "cbUseLimitedEggIncubators";
            this.cbUseLimitedEggIncubators.Size = new System.Drawing.Size(124, 19);
            this.cbUseLimitedEggIncubators.TabIndex = 20;
            this.cbUseLimitedEggIncubators.Text = "Use Ltd Incubators";
            this.cbUseLimitedEggIncubators.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbUseBerriesOperator);
            this.groupBox10.Controls.Add(this.label52);
            this.groupBox10.Controls.Add(this.tbUseBerriesMinCp);
            this.groupBox10.Controls.Add(this.label54);
            this.groupBox10.Controls.Add(this.tbUseBerriesMinIv);
            this.groupBox10.Controls.Add(this.label56);
            this.groupBox10.Controls.Add(this.tbUseBerriesBelowCatchProbability);
            this.groupBox10.Location = new System.Drawing.Point(10, 195);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(240, 120);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Use Berries:";
            // 
            // cbUseBerriesOperator
            // 
            this.cbUseBerriesOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUseBerriesOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUseBerriesOperator.FormattingEnabled = true;
            this.cbUseBerriesOperator.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cbUseBerriesOperator.Location = new System.Drawing.Point(170, 40);
            this.cbUseBerriesOperator.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseBerriesOperator.Name = "cbUseBerriesOperator";
            this.cbUseBerriesOperator.Size = new System.Drawing.Size(60, 23);
            this.cbUseBerriesOperator.TabIndex = 17;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(6, 17);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(49, 15);
            this.label52.TabIndex = 4;
            this.label52.Text = "Min CP:";
            // 
            // tbUseBerriesMinCp
            // 
            this.tbUseBerriesMinCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseBerriesMinCp.Location = new System.Drawing.Point(170, 14);
            this.tbUseBerriesMinCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseBerriesMinCp.Name = "tbUseBerriesMinCp";
            this.tbUseBerriesMinCp.Size = new System.Drawing.Size(60, 23);
            this.tbUseBerriesMinCp.TabIndex = 5;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(6, 67);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 15);
            this.label54.TabIndex = 4;
            this.label54.Text = "Min IV:";
            // 
            // tbUseBerriesMinIv
            // 
            this.tbUseBerriesMinIv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseBerriesMinIv.Location = new System.Drawing.Point(170, 66);
            this.tbUseBerriesMinIv.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseBerriesMinIv.Name = "tbUseBerriesMinIv";
            this.tbUseBerriesMinIv.Size = new System.Drawing.Size(60, 23);
            this.tbUseBerriesMinIv.TabIndex = 5;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(6, 91);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(104, 15);
            this.label56.TabIndex = 4;
            this.label56.Text = "Below Catch Prob:";
            // 
            // tbUseBerriesBelowCatchProbability
            // 
            this.tbUseBerriesBelowCatchProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseBerriesBelowCatchProbability.Location = new System.Drawing.Point(170, 90);
            this.tbUseBerriesBelowCatchProbability.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseBerriesBelowCatchProbability.Name = "tbUseBerriesBelowCatchProbability";
            this.tbUseBerriesBelowCatchProbability.Size = new System.Drawing.Size(60, 23);
            this.tbUseBerriesBelowCatchProbability.TabIndex = 5;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.groupBox25);
            this.groupBox9.Controls.Add(this.groupBox23);
            this.groupBox9.Controls.Add(this.groupBox24);
            this.groupBox9.Location = new System.Drawing.Point(256, 6);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(220, 280);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "PokeBall\'s";
            // 
            // groupBox25
            // 
            this.groupBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox25.Controls.Add(this.tbUseMasterBallBelowCatchProbability);
            this.groupBox25.Controls.Add(this.tbUseMasterBallAboveCp);
            this.groupBox25.Controls.Add(this.label4);
            this.groupBox25.Controls.Add(this.label42);
            this.groupBox25.Location = new System.Drawing.Point(6, 206);
            this.groupBox25.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox25.Name = "groupBox25";
            this.groupBox25.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox25.Size = new System.Drawing.Size(210, 70);
            this.groupBox25.TabIndex = 25;
            this.groupBox25.TabStop = false;
            this.groupBox25.Text = "Use Master Balls:";
            // 
            // tbUseMasterBallBelowCatchProbability
            // 
            this.tbUseMasterBallBelowCatchProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseMasterBallBelowCatchProbability.Location = new System.Drawing.Point(140, 40);
            this.tbUseMasterBallBelowCatchProbability.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseMasterBallBelowCatchProbability.Name = "tbUseMasterBallBelowCatchProbability";
            this.tbUseMasterBallBelowCatchProbability.Size = new System.Drawing.Size(60, 23);
            this.tbUseMasterBallBelowCatchProbability.TabIndex = 5;
            // 
            // tbUseMasterBallAboveCp
            // 
            this.tbUseMasterBallAboveCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseMasterBallAboveCp.Location = new System.Drawing.Point(140, 14);
            this.tbUseMasterBallAboveCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseMasterBallAboveCp.Name = "tbUseMasterBallAboveCp";
            this.tbUseMasterBallAboveCp.Size = new System.Drawing.Size(60, 23);
            this.tbUseMasterBallAboveCp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Above CP:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 42);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(104, 15);
            this.label42.TabIndex = 4;
            this.label42.Text = "Below Catch Prob:";
            // 
            // groupBox23
            // 
            this.groupBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox23.Controls.Add(this.label2);
            this.groupBox23.Controls.Add(this.tbUseGreatBallAboveIv);
            this.groupBox23.Controls.Add(this.tbUseGreatBallAboveCp);
            this.groupBox23.Controls.Add(this.label6);
            this.groupBox23.Controls.Add(this.label40);
            this.groupBox23.Controls.Add(this.tbUseGreatBallBelowCatchProbability);
            this.groupBox23.Location = new System.Drawing.Point(6, 14);
            this.groupBox23.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox23.Name = "groupBox23";
            this.groupBox23.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox23.Size = new System.Drawing.Size(210, 94);
            this.groupBox23.TabIndex = 23;
            this.groupBox23.TabStop = false;
            this.groupBox23.Text = "Use Great Balls:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Above CP:\r\n";
            // 
            // tbUseGreatBallAboveIv
            // 
            this.tbUseGreatBallAboveIv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseGreatBallAboveIv.Location = new System.Drawing.Point(140, 40);
            this.tbUseGreatBallAboveIv.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseGreatBallAboveIv.Name = "tbUseGreatBallAboveIv";
            this.tbUseGreatBallAboveIv.Size = new System.Drawing.Size(60, 23);
            this.tbUseGreatBallAboveIv.TabIndex = 5;
            // 
            // tbUseGreatBallAboveCp
            // 
            this.tbUseGreatBallAboveCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseGreatBallAboveCp.Location = new System.Drawing.Point(140, 14);
            this.tbUseGreatBallAboveCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseGreatBallAboveCp.Name = "tbUseGreatBallAboveCp";
            this.tbUseGreatBallAboveCp.Size = new System.Drawing.Size(60, 23);
            this.tbUseGreatBallAboveCp.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Above IV:\r\n";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 67);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(104, 15);
            this.label40.TabIndex = 4;
            this.label40.Text = "Below Catch Prob:\r\n";
            // 
            // tbUseGreatBallBelowCatchProbability
            // 
            this.tbUseGreatBallBelowCatchProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseGreatBallBelowCatchProbability.Location = new System.Drawing.Point(140, 66);
            this.tbUseGreatBallBelowCatchProbability.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseGreatBallBelowCatchProbability.Name = "tbUseGreatBallBelowCatchProbability";
            this.tbUseGreatBallBelowCatchProbability.Size = new System.Drawing.Size(60, 23);
            this.tbUseGreatBallBelowCatchProbability.TabIndex = 5;
            // 
            // groupBox24
            // 
            this.groupBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox24.Controls.Add(this.label3);
            this.groupBox24.Controls.Add(this.tbUseUltraBallAboveCp);
            this.groupBox24.Controls.Add(this.tbUseUltraBallBelowCatchProbability);
            this.groupBox24.Controls.Add(this.label36);
            this.groupBox24.Controls.Add(this.label41);
            this.groupBox24.Controls.Add(this.tbUseUltraBallAboveIv);
            this.groupBox24.Location = new System.Drawing.Point(6, 110);
            this.groupBox24.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox24.Name = "groupBox24";
            this.groupBox24.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox24.Size = new System.Drawing.Size(210, 94);
            this.groupBox24.TabIndex = 24;
            this.groupBox24.TabStop = false;
            this.groupBox24.Text = "Use Ultra Balls:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Above CP:\r\n";
            // 
            // tbUseUltraBallAboveCp
            // 
            this.tbUseUltraBallAboveCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseUltraBallAboveCp.Location = new System.Drawing.Point(140, 14);
            this.tbUseUltraBallAboveCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseUltraBallAboveCp.Name = "tbUseUltraBallAboveCp";
            this.tbUseUltraBallAboveCp.Size = new System.Drawing.Size(60, 23);
            this.tbUseUltraBallAboveCp.TabIndex = 5;
            // 
            // tbUseUltraBallBelowCatchProbability
            // 
            this.tbUseUltraBallBelowCatchProbability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseUltraBallBelowCatchProbability.Location = new System.Drawing.Point(140, 66);
            this.tbUseUltraBallBelowCatchProbability.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseUltraBallBelowCatchProbability.Name = "tbUseUltraBallBelowCatchProbability";
            this.tbUseUltraBallBelowCatchProbability.Size = new System.Drawing.Size(60, 23);
            this.tbUseUltraBallBelowCatchProbability.TabIndex = 5;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 42);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 15);
            this.label36.TabIndex = 4;
            this.label36.Text = "Above IV:\r\n";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(6, 67);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(104, 15);
            this.label41.TabIndex = 4;
            this.label41.Text = "Below Catch Prob:";
            // 
            // tbUseUltraBallAboveIv
            // 
            this.tbUseUltraBallAboveIv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUseUltraBallAboveIv.Location = new System.Drawing.Point(140, 40);
            this.tbUseUltraBallAboveIv.Margin = new System.Windows.Forms.Padding(2);
            this.tbUseUltraBallAboveIv.Name = "tbUseUltraBallAboveIv";
            this.tbUseUltraBallAboveIv.Size = new System.Drawing.Size(60, 23);
            this.tbUseUltraBallAboveIv.TabIndex = 5;
            // 
            // gbCatchIgnore
            // 
            this.gbCatchIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbCatchIgnore.Controls.Add(this.clbCatchIgnore);
            this.gbCatchIgnore.Controls.Add(this.cbIgnoreAll);
            this.gbCatchIgnore.Location = new System.Drawing.Point(482, 6);
            this.gbCatchIgnore.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbCatchIgnore.Name = "gbCatchIgnore";
            this.gbCatchIgnore.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbCatchIgnore.Size = new System.Drawing.Size(270, 361);
            this.gbCatchIgnore.TabIndex = 3;
            this.gbCatchIgnore.TabStop = false;
            this.gbCatchIgnore.Text = "Ignore";
            // 
            // clbCatchIgnore
            // 
            this.clbCatchIgnore.CheckOnClick = true;
            this.clbCatchIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbCatchIgnore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCatchIgnore.FormattingEnabled = true;
            this.clbCatchIgnore.Location = new System.Drawing.Point(2, 20);
            this.clbCatchIgnore.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clbCatchIgnore.Name = "clbCatchIgnore";
            this.clbCatchIgnore.Size = new System.Drawing.Size(266, 337);
            this.clbCatchIgnore.TabIndex = 0;
            // 
            // cbIgnoreAll
            // 
            this.cbIgnoreAll.AutoSize = true;
            this.cbIgnoreAll.Location = new System.Drawing.Point(130, 0);
            this.cbIgnoreAll.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbIgnoreAll.Name = "cbIgnoreAll";
            this.cbIgnoreAll.Size = new System.Drawing.Size(74, 19);
            this.cbIgnoreAll.TabIndex = 1;
            this.cbIgnoreAll.Text = "Select All";
            this.cbIgnoreAll.UseVisualStyleBackColor = true;
            this.cbIgnoreAll.CheckedChanged += new System.EventHandler(this.CbSelectAllCatch_CheckedChanged);
            // 
            // cbUseEggIncubators
            // 
            this.cbUseEggIncubators.AutoSize = true;
            this.cbUseEggIncubators.Location = new System.Drawing.Point(14, 6);
            this.cbUseEggIncubators.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseEggIncubators.Name = "cbUseEggIncubators";
            this.cbUseEggIncubators.Size = new System.Drawing.Size(104, 19);
            this.cbUseEggIncubators.TabIndex = 1;
            this.cbUseEggIncubators.Text = "Use Incubators";
            this.cbUseEggIncubators.UseVisualStyleBackColor = true;
            this.cbUseEggIncubators.CheckedChanged += new System.EventHandler(this.cbUseEggIncubators_CheckedChanged);
            // 
            // cbCatchPoke
            // 
            this.cbCatchPoke.AutoSize = true;
            this.cbCatchPoke.Location = new System.Drawing.Point(14, 27);
            this.cbCatchPoke.Margin = new System.Windows.Forms.Padding(2);
            this.cbCatchPoke.Name = "cbCatchPoke";
            this.cbCatchPoke.Size = new System.Drawing.Size(111, 19);
            this.cbCatchPoke.TabIndex = 1;
            this.cbCatchPoke.Text = "Catch Pokemon";
            this.cbCatchPoke.UseVisualStyleBackColor = true;
            this.cbCatchPoke.CheckedChanged += new System.EventHandler(this.cbCatchPoke_CheckedChanged);
            // 
            // gbCatchPokemon
            // 
            this.gbCatchPokemon.Controls.Add(this.label27);
            this.gbCatchPokemon.Controls.Add(this.cbAutoFavoriteShinyOnCatch);
            this.gbCatchPokemon.Controls.Add(this.tBMaxBerriesToUsePerPokemon);
            this.gbCatchPokemon.Controls.Add(this.label47);
            this.gbCatchPokemon.Controls.Add(this.label43);
            this.gbCatchPokemon.Controls.Add(this.cbAutoFavoritePokemon);
            this.gbCatchPokemon.Controls.Add(this.tbMaxPokeballsPerPokemon);
            this.gbCatchPokemon.Controls.Add(this.tbFavoriteMinIvPercentage);
            this.gbCatchPokemon.Enabled = false;
            this.gbCatchPokemon.Location = new System.Drawing.Point(10, 41);
            this.gbCatchPokemon.Margin = new System.Windows.Forms.Padding(2);
            this.gbCatchPokemon.Name = "gbCatchPokemon";
            this.gbCatchPokemon.Padding = new System.Windows.Forms.Padding(2);
            this.gbCatchPokemon.Size = new System.Drawing.Size(240, 146);
            this.gbCatchPokemon.TabIndex = 22;
            this.gbCatchPokemon.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 18);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(128, 15);
            this.label27.TabIndex = 1;
            this.label27.Text = "Berry to use/Pokemon:\r\n";
            // 
            // cbAutoFavoriteShinyOnCatch
            // 
            this.cbAutoFavoriteShinyOnCatch.AutoSize = true;
            this.cbAutoFavoriteShinyOnCatch.Location = new System.Drawing.Point(6, 118);
            this.cbAutoFavoriteShinyOnCatch.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoFavoriteShinyOnCatch.Name = "cbAutoFavoriteShinyOnCatch";
            this.cbAutoFavoriteShinyOnCatch.Size = new System.Drawing.Size(170, 19);
            this.cbAutoFavoriteShinyOnCatch.TabIndex = 21;
            this.cbAutoFavoriteShinyOnCatch.Text = "AutoFavoriteShinyOnCatch";
            this.cbAutoFavoriteShinyOnCatch.UseVisualStyleBackColor = true;
            // 
            // tBMaxBerriesToUsePerPokemon
            // 
            this.tBMaxBerriesToUsePerPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMaxBerriesToUsePerPokemon.Location = new System.Drawing.Point(170, 16);
            this.tBMaxBerriesToUsePerPokemon.Margin = new System.Windows.Forms.Padding(2);
            this.tBMaxBerriesToUsePerPokemon.Name = "tBMaxBerriesToUsePerPokemon";
            this.tBMaxBerriesToUsePerPokemon.Size = new System.Drawing.Size(60, 23);
            this.tBMaxBerriesToUsePerPokemon.TabIndex = 2;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 93);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(101, 15);
            this.label47.TabIndex = 4;
            this.label47.Text = "Favorite Min-IV%:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 43);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(144, 15);
            this.label43.TabIndex = 7;
            this.label43.Text = "Max Poke balls/Pokemon:\r\n";
            // 
            // cbAutoFavoritePokemon
            // 
            this.cbAutoFavoritePokemon.AutoSize = true;
            this.cbAutoFavoritePokemon.Location = new System.Drawing.Point(6, 68);
            this.cbAutoFavoritePokemon.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoFavoritePokemon.Name = "cbAutoFavoritePokemon";
            this.cbAutoFavoritePokemon.Size = new System.Drawing.Size(153, 19);
            this.cbAutoFavoritePokemon.TabIndex = 19;
            this.cbAutoFavoritePokemon.Text = "Auto-Favorite Pokemon";
            this.cbAutoFavoritePokemon.UseVisualStyleBackColor = true;
            // 
            // tbMaxPokeballsPerPokemon
            // 
            this.tbMaxPokeballsPerPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxPokeballsPerPokemon.Location = new System.Drawing.Point(170, 42);
            this.tbMaxPokeballsPerPokemon.Margin = new System.Windows.Forms.Padding(2);
            this.tbMaxPokeballsPerPokemon.Name = "tbMaxPokeballsPerPokemon";
            this.tbMaxPokeballsPerPokemon.Size = new System.Drawing.Size(60, 23);
            this.tbMaxPokeballsPerPokemon.TabIndex = 8;
            // 
            // tbFavoriteMinIvPercentage
            // 
            this.tbFavoriteMinIvPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFavoriteMinIvPercentage.Location = new System.Drawing.Point(170, 90);
            this.tbFavoriteMinIvPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.tbFavoriteMinIvPercentage.Name = "tbFavoriteMinIvPercentage";
            this.tbFavoriteMinIvPercentage.Size = new System.Drawing.Size(60, 23);
            this.tbFavoriteMinIvPercentage.TabIndex = 5;
            // 
            // tabTransfer
            // 
            this.tabTransfer.BackColor = System.Drawing.SystemColors.Control;
            this.tabTransfer.Controls.Add(this.groupBox7);
            this.tabTransfer.Controls.Add(this.gbExcludeTrans);
            this.tabTransfer.Controls.Add(this.groupBox8);
            this.tabTransfer.Location = new System.Drawing.Point(4, 24);
            this.tabTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Padding = new System.Windows.Forms.Padding(2);
            this.tabTransfer.Size = new System.Drawing.Size(754, 358);
            this.tabTransfer.TabIndex = 1;
            this.tabTransfer.Text = "Transfer";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbTransferDuplicatePokemonOnCapture);
            this.groupBox7.Controls.Add(this.cbTransferDuplicatePokemon);
            this.groupBox7.Controls.Add(this.cbTransferWeakPokemon);
            this.groupBox7.Controls.Add(this.tbKeepMinDuplicatePokemon);
            this.groupBox7.Controls.Add(this.label35);
            this.groupBox7.Controls.Add(this.cbPrioritizeIvOverCp);
            this.groupBox7.Controls.Add(this.tbKeepMinIV);
            this.groupBox7.Controls.Add(this.cbKeepMinOperator);
            this.groupBox7.Controls.Add(this.tbKeepMinCp);
            this.groupBox7.Controls.Add(this.label38);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Location = new System.Drawing.Point(10, 6);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(250, 214);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Condiction";
            // 
            // cbTransferDuplicatePokemonOnCapture
            // 
            this.cbTransferDuplicatePokemonOnCapture.AutoSize = true;
            this.cbTransferDuplicatePokemonOnCapture.Location = new System.Drawing.Point(10, 192);
            this.cbTransferDuplicatePokemonOnCapture.Margin = new System.Windows.Forms.Padding(2);
            this.cbTransferDuplicatePokemonOnCapture.Name = "cbTransferDuplicatePokemonOnCapture";
            this.cbTransferDuplicatePokemonOnCapture.Size = new System.Drawing.Size(239, 19);
            this.cbTransferDuplicatePokemonOnCapture.TabIndex = 24;
            this.cbTransferDuplicatePokemonOnCapture.Text = "Transfer Duplicate Pokemon On Capture";
            this.cbTransferDuplicatePokemonOnCapture.UseVisualStyleBackColor = true;
            // 
            // cbTransferDuplicatePokemon
            // 
            this.cbTransferDuplicatePokemon.AutoSize = true;
            this.cbTransferDuplicatePokemon.Location = new System.Drawing.Point(10, 168);
            this.cbTransferDuplicatePokemon.Margin = new System.Windows.Forms.Padding(2);
            this.cbTransferDuplicatePokemon.Name = "cbTransferDuplicatePokemon";
            this.cbTransferDuplicatePokemon.Size = new System.Drawing.Size(175, 19);
            this.cbTransferDuplicatePokemon.TabIndex = 24;
            this.cbTransferDuplicatePokemon.Text = "Transfer Duplicate Pokemon";
            this.cbTransferDuplicatePokemon.UseVisualStyleBackColor = true;
            // 
            // cbTransferWeakPokemon
            // 
            this.cbTransferWeakPokemon.AutoSize = true;
            this.cbTransferWeakPokemon.Location = new System.Drawing.Point(10, 144);
            this.cbTransferWeakPokemon.Margin = new System.Windows.Forms.Padding(2);
            this.cbTransferWeakPokemon.Name = "cbTransferWeakPokemon";
            this.cbTransferWeakPokemon.Size = new System.Drawing.Size(154, 19);
            this.cbTransferWeakPokemon.TabIndex = 24;
            this.cbTransferWeakPokemon.Text = "Transfer Weak Pokemon";
            this.cbTransferWeakPokemon.UseVisualStyleBackColor = true;
            // 
            // tbKeepMinDuplicatePokemon
            // 
            this.tbKeepMinDuplicatePokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeepMinDuplicatePokemon.Location = new System.Drawing.Point(180, 116);
            this.tbKeepMinDuplicatePokemon.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeepMinDuplicatePokemon.Name = "tbKeepMinDuplicatePokemon";
            this.tbKeepMinDuplicatePokemon.Size = new System.Drawing.Size(60, 23);
            this.tbKeepMinDuplicatePokemon.TabIndex = 23;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(10, 118);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(143, 15);
            this.label35.TabIndex = 22;
            this.label35.Text = "Keep Duplicate Pokemon:\r\n";
            // 
            // cbPrioritizeIvOverCp
            // 
            this.cbPrioritizeIvOverCp.AutoSize = true;
            this.cbPrioritizeIvOverCp.Location = new System.Drawing.Point(10, 20);
            this.cbPrioritizeIvOverCp.Margin = new System.Windows.Forms.Padding(2);
            this.cbPrioritizeIvOverCp.Name = "cbPrioritizeIvOverCp";
            this.cbPrioritizeIvOverCp.Size = new System.Drawing.Size(131, 19);
            this.cbPrioritizeIvOverCp.TabIndex = 21;
            this.cbPrioritizeIvOverCp.Text = "Prioritize IV Over CP";
            this.cbPrioritizeIvOverCp.UseVisualStyleBackColor = true;
            // 
            // tbKeepMinIV
            // 
            this.tbKeepMinIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeepMinIV.Location = new System.Drawing.Point(180, 90);
            this.tbKeepMinIV.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeepMinIV.Name = "tbKeepMinIV";
            this.tbKeepMinIV.Size = new System.Drawing.Size(60, 23);
            this.tbKeepMinIV.TabIndex = 12;
            // 
            // cbKeepMinOperator
            // 
            this.cbKeepMinOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKeepMinOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeepMinOperator.FormattingEnabled = true;
            this.cbKeepMinOperator.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cbKeepMinOperator.Location = new System.Drawing.Point(180, 66);
            this.cbKeepMinOperator.Margin = new System.Windows.Forms.Padding(2);
            this.cbKeepMinOperator.Name = "cbKeepMinOperator";
            this.cbKeepMinOperator.Size = new System.Drawing.Size(60, 23);
            this.cbKeepMinOperator.TabIndex = 11;
            // 
            // tbKeepMinCp
            // 
            this.tbKeepMinCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeepMinCp.Location = new System.Drawing.Point(180, 42);
            this.tbKeepMinCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeepMinCp.Name = "tbKeepMinCp";
            this.tbKeepMinCp.Size = new System.Drawing.Size(60, 23);
            this.tbKeepMinCp.TabIndex = 11;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(10, 90);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(85, 15);
            this.label38.TabIndex = 10;
            this.label38.Text = "Keep Min-IV%:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(10, 43);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(80, 15);
            this.label39.TabIndex = 8;
            this.label39.Text = "Keep Min-CP:";
            // 
            // gbExcludeTrans
            // 
            this.gbExcludeTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbExcludeTrans.Controls.Add(this.clbTransfer);
            this.gbExcludeTrans.Controls.Add(this.cbNotTransferAll);
            this.gbExcludeTrans.Location = new System.Drawing.Point(482, 6);
            this.gbExcludeTrans.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbExcludeTrans.Name = "gbExcludeTrans";
            this.gbExcludeTrans.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbExcludeTrans.Size = new System.Drawing.Size(270, 413);
            this.gbExcludeTrans.TabIndex = 20;
            this.gbExcludeTrans.TabStop = false;
            this.gbExcludeTrans.Text = "Exclude";
            // 
            // clbTransfer
            // 
            this.clbTransfer.CheckOnClick = true;
            this.clbTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTransfer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTransfer.FormattingEnabled = true;
            this.clbTransfer.Location = new System.Drawing.Point(2, 20);
            this.clbTransfer.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clbTransfer.Name = "clbTransfer";
            this.clbTransfer.Size = new System.Drawing.Size(266, 389);
            this.clbTransfer.TabIndex = 0;
            // 
            // cbNotTransferAll
            // 
            this.cbNotTransferAll.AutoSize = true;
            this.cbNotTransferAll.Location = new System.Drawing.Point(130, 0);
            this.cbNotTransferAll.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbNotTransferAll.Name = "cbNotTransferAll";
            this.cbNotTransferAll.Size = new System.Drawing.Size(74, 19);
            this.cbNotTransferAll.TabIndex = 1;
            this.cbNotTransferAll.Text = "Select All";
            this.cbNotTransferAll.UseVisualStyleBackColor = true;
            this.cbNotTransferAll.CheckedChanged += new System.EventHandler(this.CbSelectAllTransfer_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbKeepPokemonsToBeEvolved);
            this.groupBox8.Controls.Add(this.tbKeepMinLvl);
            this.groupBox8.Controls.Add(this.cbUseKeepMinLvl);
            this.groupBox8.Controls.Add(this.label37);
            this.groupBox8.Location = new System.Drawing.Point(10, 224);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(250, 92);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Additional Condiction";
            // 
            // cbKeepPokemonsToBeEvolved
            // 
            this.cbKeepPokemonsToBeEvolved.AutoSize = true;
            this.cbKeepPokemonsToBeEvolved.Location = new System.Drawing.Point(10, 67);
            this.cbKeepPokemonsToBeEvolved.Margin = new System.Windows.Forms.Padding(2);
            this.cbKeepPokemonsToBeEvolved.Name = "cbKeepPokemonsToBeEvolved";
            this.cbKeepPokemonsToBeEvolved.Size = new System.Drawing.Size(192, 19);
            this.cbKeepPokemonsToBeEvolved.TabIndex = 21;
            this.cbKeepPokemonsToBeEvolved.Text = "Keep If Pokemon To Be Evolved";
            this.cbKeepPokemonsToBeEvolved.UseVisualStyleBackColor = true;
            // 
            // tbKeepMinLvl
            // 
            this.tbKeepMinLvl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeepMinLvl.Location = new System.Drawing.Point(180, 40);
            this.tbKeepMinLvl.Margin = new System.Windows.Forms.Padding(2);
            this.tbKeepMinLvl.Name = "tbKeepMinLvl";
            this.tbKeepMinLvl.Size = new System.Drawing.Size(60, 23);
            this.tbKeepMinLvl.TabIndex = 17;
            // 
            // cbUseKeepMinLvl
            // 
            this.cbUseKeepMinLvl.AutoSize = true;
            this.cbUseKeepMinLvl.Location = new System.Drawing.Point(10, 20);
            this.cbUseKeepMinLvl.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseKeepMinLvl.Name = "cbUseKeepMinLvl";
            this.cbUseKeepMinLvl.Size = new System.Drawing.Size(190, 19);
            this.cbUseKeepMinLvl.TabIndex = 20;
            this.cbUseKeepMinLvl.Text = "Use Keep Min Level Condiction\r\n";
            this.cbUseKeepMinLvl.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(10, 42);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(92, 15);
            this.label37.TabIndex = 16;
            this.label37.Text = "Keep Min-Level:";
            // 
            // tabPowerUp
            // 
            this.tabPowerUp.BackColor = System.Drawing.SystemColors.Control;
            this.tabPowerUp.Controls.Add(this.cbPowerUpFav);
            this.tabPowerUp.Controls.Add(this.groupBox6);
            this.tabPowerUp.Controls.Add(this.cbPowerUpType);
            this.tabPowerUp.Controls.Add(this.label29);
            this.tabPowerUp.Controls.Add(this.gbPUP);
            this.tabPowerUp.Controls.Add(this.cbAutoPowerUp);
            this.tabPowerUp.Location = new System.Drawing.Point(4, 24);
            this.tabPowerUp.Margin = new System.Windows.Forms.Padding(2);
            this.tabPowerUp.Name = "tabPowerUp";
            this.tabPowerUp.Size = new System.Drawing.Size(754, 358);
            this.tabPowerUp.TabIndex = 4;
            this.tabPowerUp.Text = "PowerUp";
            // 
            // cbPowerUpFav
            // 
            this.cbPowerUpFav.AutoSize = true;
            this.cbPowerUpFav.Location = new System.Drawing.Point(14, 27);
            this.cbPowerUpFav.Margin = new System.Windows.Forms.Padding(2);
            this.cbPowerUpFav.Name = "cbPowerUpFav";
            this.cbPowerUpFav.Size = new System.Drawing.Size(152, 19);
            this.cbPowerUpFav.TabIndex = 11;
            this.cbPowerUpFav.Text = "Only PowerUp Favorites\r\n";
            this.cbPowerUpFav.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbPowerUpMinIV);
            this.groupBox6.Controls.Add(this.cbPowerUpCondiction);
            this.groupBox6.Controls.Add(this.tbPowerUpMinCP);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.cbPowerUpMinStarDust);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Location = new System.Drawing.Point(10, 78);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(234, 130);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Condiction";
            // 
            // tbPowerUpMinIV
            // 
            this.tbPowerUpMinIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPowerUpMinIV.Location = new System.Drawing.Point(166, 94);
            this.tbPowerUpMinIV.Margin = new System.Windows.Forms.Padding(2);
            this.tbPowerUpMinIV.Name = "tbPowerUpMinIV";
            this.tbPowerUpMinIV.Size = new System.Drawing.Size(60, 23);
            this.tbPowerUpMinIV.TabIndex = 12;
            // 
            // cbPowerUpCondiction
            // 
            this.cbPowerUpCondiction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPowerUpCondiction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerUpCondiction.FormattingEnabled = true;
            this.cbPowerUpCondiction.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.cbPowerUpCondiction.Location = new System.Drawing.Point(166, 46);
            this.cbPowerUpCondiction.Margin = new System.Windows.Forms.Padding(2);
            this.cbPowerUpCondiction.Name = "cbPowerUpCondiction";
            this.cbPowerUpCondiction.Size = new System.Drawing.Size(60, 23);
            this.cbPowerUpCondiction.TabIndex = 11;
            // 
            // tbPowerUpMinCP
            // 
            this.tbPowerUpMinCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPowerUpMinCP.Location = new System.Drawing.Point(166, 70);
            this.tbPowerUpMinCP.Margin = new System.Windows.Forms.Padding(2);
            this.tbPowerUpMinCP.Name = "tbPowerUpMinCP";
            this.tbPowerUpMinCP.Size = new System.Drawing.Size(60, 23);
            this.tbPowerUpMinCP.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 97);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(56, 15);
            this.label31.TabIndex = 10;
            this.label31.Text = "Min-IV%:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 73);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 15);
            this.label30.TabIndex = 8;
            this.label30.Text = "Min-CP:";
            // 
            // cbPowerUpMinStarDust
            // 
            this.cbPowerUpMinStarDust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPowerUpMinStarDust.FormattingEnabled = true;
            this.cbPowerUpMinStarDust.Items.AddRange(new object[] {
            "200",
            "400",
            "600",
            "800",
            "1000",
            "1300",
            "1600",
            "1900",
            "2200",
            "2500",
            "3000",
            "3500",
            "4000",
            "4500",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000",
            "10000",
            "20000"});
            this.cbPowerUpMinStarDust.Location = new System.Drawing.Point(166, 20);
            this.cbPowerUpMinStarDust.Margin = new System.Windows.Forms.Padding(2);
            this.cbPowerUpMinStarDust.Name = "cbPowerUpMinStarDust";
            this.cbPowerUpMinStarDust.Size = new System.Drawing.Size(60, 23);
            this.cbPowerUpMinStarDust.TabIndex = 7;
            this.cbPowerUpMinStarDust.Text = "5000";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 22);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 15);
            this.label28.TabIndex = 6;
            this.label28.Text = "Min-StarDust For PowerUp:\r\n";
            // 
            // cbPowerUpType
            // 
            this.cbPowerUpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPowerUpType.FormattingEnabled = true;
            this.cbPowerUpType.Items.AddRange(new object[] {
            "IV",
            "CP"});
            this.cbPowerUpType.Location = new System.Drawing.Point(174, 50);
            this.cbPowerUpType.Margin = new System.Windows.Forms.Padding(2);
            this.cbPowerUpType.Name = "cbPowerUpType";
            this.cbPowerUpType.Size = new System.Drawing.Size(60, 23);
            this.cbPowerUpType.TabIndex = 9;
            this.cbPowerUpType.SelectionChangeCommitted += new System.EventHandler(this.CbPowerUpType_SelectionChangeCommitted);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 53);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 15);
            this.label29.TabIndex = 8;
            this.label29.Text = "PowerUp Type:";
            // 
            // gbPUP
            // 
            this.gbPUP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPUP.Controls.Add(this.clbPowerUp);
            this.gbPUP.Controls.Add(this.cbPowerUpAll);
            this.gbPUP.Location = new System.Drawing.Point(482, 6);
            this.gbPUP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbPUP.Name = "gbPUP";
            this.gbPUP.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbPUP.Size = new System.Drawing.Size(270, 413);
            this.gbPUP.TabIndex = 5;
            this.gbPUP.TabStop = false;
            this.gbPUP.Text = "Power Up";
            // 
            // clbPowerUp
            // 
            this.clbPowerUp.CheckOnClick = true;
            this.clbPowerUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbPowerUp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbPowerUp.FormattingEnabled = true;
            this.clbPowerUp.Location = new System.Drawing.Point(2, 20);
            this.clbPowerUp.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clbPowerUp.Name = "clbPowerUp";
            this.clbPowerUp.Size = new System.Drawing.Size(266, 389);
            this.clbPowerUp.TabIndex = 0;
            // 
            // cbPowerUpAll
            // 
            this.cbPowerUpAll.AutoSize = true;
            this.cbPowerUpAll.Location = new System.Drawing.Point(130, 0);
            this.cbPowerUpAll.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbPowerUpAll.Name = "cbPowerUpAll";
            this.cbPowerUpAll.Size = new System.Drawing.Size(74, 19);
            this.cbPowerUpAll.TabIndex = 1;
            this.cbPowerUpAll.Text = "Select All";
            this.cbPowerUpAll.UseVisualStyleBackColor = true;
            this.cbPowerUpAll.CheckedChanged += new System.EventHandler(this.CbPowerUpAll_CheckedChanged);
            // 
            // cbAutoPowerUp
            // 
            this.cbAutoPowerUp.AutoSize = true;
            this.cbAutoPowerUp.Location = new System.Drawing.Point(14, 6);
            this.cbAutoPowerUp.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoPowerUp.Name = "cbAutoPowerUp";
            this.cbAutoPowerUp.Size = new System.Drawing.Size(106, 19);
            this.cbAutoPowerUp.TabIndex = 4;
            this.cbAutoPowerUp.Text = "Auto Power Up";
            this.cbAutoPowerUp.UseVisualStyleBackColor = true;
            // 
            // tabEvo
            // 
            this.tabEvo.BackColor = System.Drawing.SystemColors.Control;
            this.tabEvo.Controls.Add(this.groupBox2);
            this.tabEvo.Controls.Add(this.cbEvolveAll);
            this.tabEvo.Controls.Add(this.groupBox1);
            this.tabEvo.Controls.Add(this.groupBox5);
            this.tabEvo.Controls.Add(this.gbEvolve);
            this.tabEvo.Location = new System.Drawing.Point(4, 24);
            this.tabEvo.Margin = new System.Windows.Forms.Padding(2);
            this.tabEvo.Name = "tabEvo";
            this.tabEvo.Size = new System.Drawing.Size(754, 358);
            this.tabEvo.TabIndex = 3;
            this.tabEvo.Text = "Evolve";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.tbEvolveApplyLuckyEggOnEvolutionCountValue);
            this.groupBox2.Controls.Add(this.cbEvolveApplyLuckyEggOnEvolutionCount);
            this.groupBox2.Controls.Add(this.cbEvolvePreserveMinCandiesFromFilter);
            this.groupBox2.Location = new System.Drawing.Point(10, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(300, 80);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "When Evolving";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Location = new System.Drawing.Point(182, 248);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(102, 23);
            this.textBox12.TabIndex = 23;
            // 
            // tbEvolveApplyLuckyEggOnEvolutionCountValue
            // 
            this.tbEvolveApplyLuckyEggOnEvolutionCountValue.Location = new System.Drawing.Point(227, 43);
            this.tbEvolveApplyLuckyEggOnEvolutionCountValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbEvolveApplyLuckyEggOnEvolutionCountValue.Name = "tbEvolveApplyLuckyEggOnEvolutionCountValue";
            this.tbEvolveApplyLuckyEggOnEvolutionCountValue.Size = new System.Drawing.Size(60, 23);
            this.tbEvolveApplyLuckyEggOnEvolutionCountValue.TabIndex = 80;
            // 
            // cbEvolveApplyLuckyEggOnEvolutionCount
            // 
            this.cbEvolveApplyLuckyEggOnEvolutionCount.AutoSize = true;
            this.cbEvolveApplyLuckyEggOnEvolutionCount.Location = new System.Drawing.Point(10, 37);
            this.cbEvolveApplyLuckyEggOnEvolutionCount.Margin = new System.Windows.Forms.Padding(2);
            this.cbEvolveApplyLuckyEggOnEvolutionCount.Name = "cbEvolveApplyLuckyEggOnEvolutionCount";
            this.cbEvolveApplyLuckyEggOnEvolutionCount.Size = new System.Drawing.Size(193, 34);
            this.cbEvolveApplyLuckyEggOnEvolutionCount.TabIndex = 70;
            this.cbEvolveApplyLuckyEggOnEvolutionCount.Text = "Apply Lucky Egg If There Are At\r\nLeast This Many Evolutions:";
            this.cbEvolveApplyLuckyEggOnEvolutionCount.UseVisualStyleBackColor = true;
            // 
            // cbEvolvePreserveMinCandiesFromFilter
            // 
            this.cbEvolvePreserveMinCandiesFromFilter.AutoSize = true;
            this.cbEvolvePreserveMinCandiesFromFilter.Location = new System.Drawing.Point(10, 20);
            this.cbEvolvePreserveMinCandiesFromFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbEvolvePreserveMinCandiesFromFilter.Name = "cbEvolvePreserveMinCandiesFromFilter";
            this.cbEvolvePreserveMinCandiesFromFilter.Size = new System.Drawing.Size(279, 19);
            this.cbEvolvePreserveMinCandiesFromFilter.TabIndex = 65;
            this.cbEvolvePreserveMinCandiesFromFilter.Text = "Preserve Candies Defined As Min In Filter Details";
            this.cbEvolvePreserveMinCandiesFromFilter.UseVisualStyleBackColor = true;
            // 
            // cbEvolveAll
            // 
            this.cbEvolveAll.AutoSize = true;
            this.cbEvolveAll.Location = new System.Drawing.Point(663, 6);
            this.cbEvolveAll.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbEvolveAll.Name = "cbEvolveAll";
            this.cbEvolveAll.Size = new System.Drawing.Size(74, 19);
            this.cbEvolveAll.TabIndex = 100;
            this.cbEvolveAll.Text = "Select All";
            this.cbEvolveAll.UseVisualStyleBackColor = true;
            this.cbEvolveAll.CheckedChanged += new System.EventHandler(this.CbSelectAllEvolve_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEvolvePokemonsThatMatchFilter);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.cbEvolveAnyPokemonAboveIv);
            this.groupBox1.Controls.Add(this.tbEvolveAnyPokemonAboveIvValue);
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evolve Pokemons Filter";
            // 
            // cbEvolvePokemonsThatMatchFilter
            // 
            this.cbEvolvePokemonsThatMatchFilter.AutoSize = true;
            this.cbEvolvePokemonsThatMatchFilter.Location = new System.Drawing.Point(10, 45);
            this.cbEvolvePokemonsThatMatchFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cbEvolvePokemonsThatMatchFilter.Name = "cbEvolvePokemonsThatMatchFilter";
            this.cbEvolvePokemonsThatMatchFilter.Size = new System.Drawing.Size(185, 19);
            this.cbEvolvePokemonsThatMatchFilter.TabIndex = 15;
            this.cbEvolvePokemonsThatMatchFilter.Text = "Evolve Pokemons By Filter List";
            this.cbEvolvePokemonsThatMatchFilter.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Enabled = false;
            this.label33.Location = new System.Drawing.Point(7, 73);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(268, 30);
            this.label33.TabIndex = 20;
            this.label33.Text = "Note: filter details for each Pokemon are available\r\nin your config.json, section" +
    " PokemonEvolveFilter";
            // 
            // cbEvolveAnyPokemonAboveIv
            // 
            this.cbEvolveAnyPokemonAboveIv.AutoSize = true;
            this.cbEvolveAnyPokemonAboveIv.Location = new System.Drawing.Point(10, 22);
            this.cbEvolveAnyPokemonAboveIv.Margin = new System.Windows.Forms.Padding(2);
            this.cbEvolveAnyPokemonAboveIv.Name = "cbEvolveAnyPokemonAboveIv";
            this.cbEvolveAnyPokemonAboveIv.Size = new System.Drawing.Size(201, 19);
            this.cbEvolveAnyPokemonAboveIv.TabIndex = 5;
            this.cbEvolveAnyPokemonAboveIv.Text = "Evolve Any Pokemon Above IV%:";
            this.cbEvolveAnyPokemonAboveIv.UseVisualStyleBackColor = true;
            // 
            // tbEvolveAnyPokemonAboveIvValue
            // 
            this.tbEvolveAnyPokemonAboveIvValue.Location = new System.Drawing.Point(227, 20);
            this.tbEvolveAnyPokemonAboveIvValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbEvolveAnyPokemonAboveIvValue.Name = "tbEvolveAnyPokemonAboveIvValue";
            this.tbEvolveAnyPokemonAboveIvValue.Size = new System.Drawing.Size(60, 23);
            this.tbEvolveAnyPokemonAboveIvValue.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbTriggerEvolveIfLuckyEggIsActive);
            this.groupBox5.Controls.Add(this.tbTriggerEvolveOnStorageUsageAbsoluteValue);
            this.groupBox5.Controls.Add(this.cbTriggerEvolveOnStorageUsageAbsolute);
            this.groupBox5.Controls.Add(this.tbTriggerEvolveOnStorageUsagePercentageValue);
            this.groupBox5.Controls.Add(this.tbTriggerEvolveOnEvolutionCountValue);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.cbTriggerEvolveAsSoonAsFilterIsMatched);
            this.groupBox5.Controls.Add(this.cbTriggerEvolveOnEvolutionCount);
            this.groupBox5.Controls.Add(this.cbTriggerEvolveOnStorageUsagePercentage);
            this.groupBox5.Location = new System.Drawing.Point(10, 127);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(300, 139);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Evolve Pokemons Trigger";
            // 
            // cbTriggerEvolveIfLuckyEggIsActive
            // 
            this.cbTriggerEvolveIfLuckyEggIsActive.AutoSize = true;
            this.cbTriggerEvolveIfLuckyEggIsActive.Location = new System.Drawing.Point(10, 115);
            this.cbTriggerEvolveIfLuckyEggIsActive.Margin = new System.Windows.Forms.Padding(2);
            this.cbTriggerEvolveIfLuckyEggIsActive.Name = "cbTriggerEvolveIfLuckyEggIsActive";
            this.cbTriggerEvolveIfLuckyEggIsActive.Size = new System.Drawing.Size(137, 19);
            this.cbTriggerEvolveIfLuckyEggIsActive.TabIndex = 60;
            this.cbTriggerEvolveIfLuckyEggIsActive.Text = "If Lucky Egg Is Active";
            this.cbTriggerEvolveIfLuckyEggIsActive.UseVisualStyleBackColor = true;
            // 
            // tbTriggerEvolveOnStorageUsageAbsoluteValue
            // 
            this.tbTriggerEvolveOnStorageUsageAbsoluteValue.Location = new System.Drawing.Point(227, 90);
            this.tbTriggerEvolveOnStorageUsageAbsoluteValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbTriggerEvolveOnStorageUsageAbsoluteValue.Name = "tbTriggerEvolveOnStorageUsageAbsoluteValue";
            this.tbTriggerEvolveOnStorageUsageAbsoluteValue.Size = new System.Drawing.Size(60, 23);
            this.tbTriggerEvolveOnStorageUsageAbsoluteValue.TabIndex = 55;
            // 
            // cbTriggerEvolveOnStorageUsageAbsolute
            // 
            this.cbTriggerEvolveOnStorageUsageAbsolute.AutoSize = true;
            this.cbTriggerEvolveOnStorageUsageAbsolute.Location = new System.Drawing.Point(10, 92);
            this.cbTriggerEvolveOnStorageUsageAbsolute.Margin = new System.Windows.Forms.Padding(2);
            this.cbTriggerEvolveOnStorageUsageAbsolute.Name = "cbTriggerEvolveOnStorageUsageAbsolute";
            this.cbTriggerEvolveOnStorageUsageAbsolute.Size = new System.Drawing.Size(219, 19);
            this.cbTriggerEvolveOnStorageUsageAbsolute.TabIndex = 50;
            this.cbTriggerEvolveOnStorageUsageAbsolute.Text = "If Storage Has This Many Pokemons:";
            this.cbTriggerEvolveOnStorageUsageAbsolute.UseVisualStyleBackColor = true;
            // 
            // tbTriggerEvolveOnStorageUsagePercentageValue
            // 
            this.tbTriggerEvolveOnStorageUsagePercentageValue.Location = new System.Drawing.Point(227, 67);
            this.tbTriggerEvolveOnStorageUsagePercentageValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbTriggerEvolveOnStorageUsagePercentageValue.Name = "tbTriggerEvolveOnStorageUsagePercentageValue";
            this.tbTriggerEvolveOnStorageUsagePercentageValue.Size = new System.Drawing.Size(60, 23);
            this.tbTriggerEvolveOnStorageUsagePercentageValue.TabIndex = 45;
            // 
            // tbTriggerEvolveOnEvolutionCountValue
            // 
            this.tbTriggerEvolveOnEvolutionCountValue.Location = new System.Drawing.Point(227, 44);
            this.tbTriggerEvolveOnEvolutionCountValue.Margin = new System.Windows.Forms.Padding(2);
            this.tbTriggerEvolveOnEvolutionCountValue.Name = "tbTriggerEvolveOnEvolutionCountValue";
            this.tbTriggerEvolveOnEvolutionCountValue.Size = new System.Drawing.Size(60, 23);
            this.tbTriggerEvolveOnEvolutionCountValue.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(182, 248);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 23);
            this.textBox2.TabIndex = 23;
            // 
            // cbTriggerEvolveAsSoonAsFilterIsMatched
            // 
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.AutoSize = true;
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.Location = new System.Drawing.Point(10, 22);
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.Margin = new System.Windows.Forms.Padding(2);
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.Name = "cbTriggerEvolveAsSoonAsFilterIsMatched";
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.Size = new System.Drawing.Size(175, 19);
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.TabIndex = 25;
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.Text = "As Soon As Filter Is Matched";
            this.cbTriggerEvolveAsSoonAsFilterIsMatched.UseVisualStyleBackColor = true;
            // 
            // cbTriggerEvolveOnEvolutionCount
            // 
            this.cbTriggerEvolveOnEvolutionCount.AutoSize = true;
            this.cbTriggerEvolveOnEvolutionCount.Location = new System.Drawing.Point(10, 46);
            this.cbTriggerEvolveOnEvolutionCount.Margin = new System.Windows.Forms.Padding(2);
            this.cbTriggerEvolveOnEvolutionCount.Name = "cbTriggerEvolveOnEvolutionCount";
            this.cbTriggerEvolveOnEvolutionCount.Size = new System.Drawing.Size(206, 19);
            this.cbTriggerEvolveOnEvolutionCount.TabIndex = 30;
            this.cbTriggerEvolveOnEvolutionCount.Text = "If There Are This Many Evolutions:";
            this.cbTriggerEvolveOnEvolutionCount.UseVisualStyleBackColor = true;
            // 
            // cbTriggerEvolveOnStorageUsagePercentage
            // 
            this.cbTriggerEvolveOnStorageUsagePercentage.AutoSize = true;
            this.cbTriggerEvolveOnStorageUsagePercentage.Location = new System.Drawing.Point(10, 69);
            this.cbTriggerEvolveOnStorageUsagePercentage.Margin = new System.Windows.Forms.Padding(2);
            this.cbTriggerEvolveOnStorageUsagePercentage.Name = "cbTriggerEvolveOnStorageUsagePercentage";
            this.cbTriggerEvolveOnStorageUsagePercentage.Size = new System.Drawing.Size(148, 19);
            this.cbTriggerEvolveOnStorageUsagePercentage.TabIndex = 40;
            this.cbTriggerEvolveOnStorageUsagePercentage.Text = "If Storage Is Used To %:";
            this.cbTriggerEvolveOnStorageUsagePercentage.UseVisualStyleBackColor = true;
            // 
            // gbEvolve
            // 
            this.gbEvolve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbEvolve.Controls.Add(this.clbEvolve);
            this.gbEvolve.Location = new System.Drawing.Point(482, 6);
            this.gbEvolve.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbEvolve.Name = "gbEvolve";
            this.gbEvolve.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbEvolve.Size = new System.Drawing.Size(270, 413);
            this.gbEvolve.TabIndex = 90;
            this.gbEvolve.TabStop = false;
            this.gbEvolve.Text = "Evolve Filter List (00/000)";
            // 
            // clbEvolve
            // 
            this.clbEvolve.CheckOnClick = true;
            this.clbEvolve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbEvolve.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbEvolve.FormattingEnabled = true;
            this.clbEvolve.Location = new System.Drawing.Point(2, 20);
            this.clbEvolve.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clbEvolve.Name = "clbEvolve";
            this.clbEvolve.Size = new System.Drawing.Size(266, 389);
            this.clbEvolve.TabIndex = 0;
            // 
            // tabSnipePokemonFilter
            // 
            this.tabSnipePokemonFilter.BackColor = System.Drawing.SystemColors.Control;
            this.tabSnipePokemonFilter.Controls.Add(this.gbSnipe);
            this.tabSnipePokemonFilter.Location = new System.Drawing.Point(4, 24);
            this.tabSnipePokemonFilter.Margin = new System.Windows.Forms.Padding(2);
            this.tabSnipePokemonFilter.Name = "tabSnipePokemonFilter";
            this.tabSnipePokemonFilter.Padding = new System.Windows.Forms.Padding(2);
            this.tabSnipePokemonFilter.Size = new System.Drawing.Size(754, 358);
            this.tabSnipePokemonFilter.TabIndex = 5;
            this.tabSnipePokemonFilter.Text = "SnipePokemonFilter";
            // 
            // gbSnipe
            // 
            this.gbSnipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbSnipe.Controls.Add(this.clbSnipePokemonFilter);
            this.gbSnipe.Controls.Add(this.cbSnipePokemonFilterAll);
            this.gbSnipe.Location = new System.Drawing.Point(482, 6);
            this.gbSnipe.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbSnipe.Name = "gbSnipe";
            this.gbSnipe.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbSnipe.Size = new System.Drawing.Size(270, 413);
            this.gbSnipe.TabIndex = 17;
            this.gbSnipe.TabStop = false;
            this.gbSnipe.Text = "Snipe";
            // 
            // clbSnipePokemonFilter
            // 
            this.clbSnipePokemonFilter.CheckOnClick = true;
            this.clbSnipePokemonFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSnipePokemonFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSnipePokemonFilter.FormattingEnabled = true;
            this.clbSnipePokemonFilter.Location = new System.Drawing.Point(2, 20);
            this.clbSnipePokemonFilter.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clbSnipePokemonFilter.Name = "clbSnipePokemonFilter";
            this.clbSnipePokemonFilter.Size = new System.Drawing.Size(266, 389);
            this.clbSnipePokemonFilter.TabIndex = 0;
            // 
            // cbSnipePokemonFilterAll
            // 
            this.cbSnipePokemonFilterAll.AutoSize = true;
            this.cbSnipePokemonFilterAll.Location = new System.Drawing.Point(130, 0);
            this.cbSnipePokemonFilterAll.Margin = new System.Windows.Forms.Padding(2);
            this.cbSnipePokemonFilterAll.Name = "cbSnipePokemonFilterAll";
            this.cbSnipePokemonFilterAll.Size = new System.Drawing.Size(74, 19);
            this.cbSnipePokemonFilterAll.TabIndex = 0;
            this.cbSnipePokemonFilterAll.Text = "Select All";
            this.cbSnipePokemonFilterAll.UseVisualStyleBackColor = true;
            this.cbSnipePokemonFilterAll.CheckedChanged += new System.EventHandler(this.CbSelectAllSnipePokemonFilter_CheckedChanged);
            // 
            // tabItems
            // 
            this.tabItems.BackColor = System.Drawing.SystemColors.Control;
            this.tabItems.Controls.Add(this.cbUseIncenseConstantly);
            this.tabItems.Controls.Add(this.cbUseLuckyEggConstantly);
            this.tabItems.Controls.Add(this.groupBox14);
            this.tabItems.Controls.Add(this.groupBox13);
            this.tabItems.Location = new System.Drawing.Point(4, 24);
            this.tabItems.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabItems.Name = "tabItems";
            this.tabItems.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tabItems.Size = new System.Drawing.Size(762, 386);
            this.tabItems.TabIndex = 2;
            this.tabItems.Text = "Items";
            // 
            // cbUseIncenseConstantly
            // 
            this.cbUseIncenseConstantly.AutoSize = true;
            this.cbUseIncenseConstantly.Location = new System.Drawing.Point(18, 34);
            this.cbUseIncenseConstantly.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseIncenseConstantly.Name = "cbUseIncenseConstantly";
            this.cbUseIncenseConstantly.Size = new System.Drawing.Size(148, 19);
            this.cbUseIncenseConstantly.TabIndex = 2;
            this.cbUseIncenseConstantly.Text = "Use Incense Constantly";
            this.cbUseIncenseConstantly.UseVisualStyleBackColor = true;
            // 
            // cbUseLuckyEggConstantly
            // 
            this.cbUseLuckyEggConstantly.AutoSize = true;
            this.cbUseLuckyEggConstantly.Location = new System.Drawing.Point(18, 10);
            this.cbUseLuckyEggConstantly.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseLuckyEggConstantly.Name = "cbUseLuckyEggConstantly";
            this.cbUseLuckyEggConstantly.Size = new System.Drawing.Size(162, 19);
            this.cbUseLuckyEggConstantly.TabIndex = 2;
            this.cbUseLuckyEggConstantly.Text = "Use Lucky Egg Constantly";
            this.cbUseLuckyEggConstantly.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cbVerboseRecycling);
            this.groupBox14.Controls.Add(this.label1);
            this.groupBox14.Controls.Add(this.tbRecycleInventoryAtUsagePercentage);
            this.groupBox14.Location = new System.Drawing.Point(8, 188);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox14.Size = new System.Drawing.Size(250, 80);
            this.groupBox14.TabIndex = 18;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Recycle";
            // 
            // cbVerboseRecycling
            // 
            this.cbVerboseRecycling.AutoSize = true;
            this.cbVerboseRecycling.Location = new System.Drawing.Point(10, 20);
            this.cbVerboseRecycling.Margin = new System.Windows.Forms.Padding(2);
            this.cbVerboseRecycling.Name = "cbVerboseRecycling";
            this.cbVerboseRecycling.Size = new System.Drawing.Size(121, 19);
            this.cbVerboseRecycling.TabIndex = 16;
            this.cbVerboseRecycling.Text = "Verbose Recycling";
            this.cbVerboseRecycling.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recycle Inventory At Usage %:\r\n";
            // 
            // tbRecycleInventoryAtUsagePercentage
            // 
            this.tbRecycleInventoryAtUsagePercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecycleInventoryAtUsagePercentage.Location = new System.Drawing.Point(186, 42);
            this.tbRecycleInventoryAtUsagePercentage.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbRecycleInventoryAtUsagePercentage.Name = "tbRecycleInventoryAtUsagePercentage";
            this.tbRecycleInventoryAtUsagePercentage.Size = new System.Drawing.Size(60, 23);
            this.tbRecycleInventoryAtUsagePercentage.TabIndex = 15;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label5);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfPokeballsToKeep);
            this.groupBox13.Controls.Add(this.label44);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfPotionsToKeep);
            this.groupBox13.Controls.Add(this.label45);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfRevivesToKeep);
            this.groupBox13.Controls.Add(this.label46);
            this.groupBox13.Controls.Add(this.tbTotalAmountOfBerriesToKeep);
            this.groupBox13.Location = new System.Drawing.Point(8, 58);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox13.Size = new System.Drawing.Size(250, 130);
            this.groupBox13.TabIndex = 17;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Amount to Keep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Pokeballs To Keep:";
            // 
            // tbTotalAmountOfPokeballsToKeep
            // 
            this.tbTotalAmountOfPokeballsToKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalAmountOfPokeballsToKeep.Location = new System.Drawing.Point(186, 22);
            this.tbTotalAmountOfPokeballsToKeep.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbTotalAmountOfPokeballsToKeep.Name = "tbTotalAmountOfPokeballsToKeep";
            this.tbTotalAmountOfPokeballsToKeep.Size = new System.Drawing.Size(60, 23);
            this.tbTotalAmountOfPokeballsToKeep.TabIndex = 15;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(10, 50);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(124, 15);
            this.label44.TabIndex = 14;
            this.label44.Text = "Total Potions To Keep:\r\n";
            // 
            // tbTotalAmountOfPotionsToKeep
            // 
            this.tbTotalAmountOfPotionsToKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalAmountOfPotionsToKeep.Location = new System.Drawing.Point(186, 47);
            this.tbTotalAmountOfPotionsToKeep.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbTotalAmountOfPotionsToKeep.Name = "tbTotalAmountOfPotionsToKeep";
            this.tbTotalAmountOfPotionsToKeep.Size = new System.Drawing.Size(60, 23);
            this.tbTotalAmountOfPotionsToKeep.TabIndex = 15;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(10, 74);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(123, 15);
            this.label45.TabIndex = 14;
            this.label45.Text = "Total Revives To Keep:";
            // 
            // tbTotalAmountOfRevivesToKeep
            // 
            this.tbTotalAmountOfRevivesToKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalAmountOfRevivesToKeep.Location = new System.Drawing.Point(186, 71);
            this.tbTotalAmountOfRevivesToKeep.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbTotalAmountOfRevivesToKeep.Name = "tbTotalAmountOfRevivesToKeep";
            this.tbTotalAmountOfRevivesToKeep.Size = new System.Drawing.Size(60, 23);
            this.tbTotalAmountOfRevivesToKeep.TabIndex = 15;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(10, 98);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(119, 15);
            this.label46.TabIndex = 14;
            this.label46.Text = "Total Berries To Keep:\r\n";
            // 
            // tbTotalAmountOfBerriesToKeep
            // 
            this.tbTotalAmountOfBerriesToKeep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalAmountOfBerriesToKeep.Location = new System.Drawing.Point(186, 96);
            this.tbTotalAmountOfBerriesToKeep.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbTotalAmountOfBerriesToKeep.Name = "tbTotalAmountOfBerriesToKeep";
            this.tbTotalAmountOfBerriesToKeep.Size = new System.Drawing.Size(60, 23);
            this.tbTotalAmountOfBerriesToKeep.TabIndex = 15;
            // 
            // tabAdvSetting
            // 
            this.tabAdvSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdvSetting.Controls.Add(this.groupBox22);
            this.tabAdvSetting.Controls.Add(this.groupBox19);
            this.tabAdvSetting.Controls.Add(this.groupBox17);
            this.tabAdvSetting.Controls.Add(this.groupBox16);
            this.tabAdvSetting.Controls.Add(this.groupBox15);
            this.tabAdvSetting.Controls.Add(this.groupBox18);
            this.tabAdvSetting.Location = new System.Drawing.Point(4, 24);
            this.tabAdvSetting.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdvSetting.Name = "tabAdvSetting";
            this.tabAdvSetting.Size = new System.Drawing.Size(762, 386);
            this.tabAdvSetting.TabIndex = 4;
            this.tabAdvSetting.Text = "Advanced Settings";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.tbCatchFleeCount);
            this.groupBox22.Controls.Add(this.label78);
            this.groupBox22.Controls.Add(this.cbSelectAccountOnStartUp);
            this.groupBox22.Controls.Add(this.cbDisplayList);
            this.groupBox22.Controls.Add(this.tbPokestopSoftbanCount);
            this.groupBox22.Controls.Add(this.label77);
            this.groupBox22.Controls.Add(this.cbStartFromDefaultLocation);
            this.groupBox22.Controls.Add(this.label73);
            this.groupBox22.Controls.Add(this.tbEXPSwitch);
            this.groupBox22.Controls.Add(this.tbPokestopSwitch);
            this.groupBox22.Controls.Add(this.tbPokemonPerHourSwitch);
            this.groupBox22.Controls.Add(this.tbPokemonSwitch);
            this.groupBox22.Controls.Add(this.label76);
            this.groupBox22.Controls.Add(this.label72);
            this.groupBox22.Controls.Add(this.tbMinIVToSwitch);
            this.groupBox22.Controls.Add(this.cbOnRarePokemon);
            this.groupBox22.Controls.Add(this.label69);
            this.groupBox22.Controls.Add(this.tbRuntimeSwitch);
            this.groupBox22.Controls.Add(this.label70);
            this.groupBox22.Controls.Add(this.tbRuntimeSwitchRandomTime);
            this.groupBox22.Controls.Add(this.label71);
            this.groupBox22.Controls.Add(this.tbOnLimitPauseTimes);
            this.groupBox22.Controls.Add(this.cbSwitchOnPokestopLimit);
            this.groupBox22.Controls.Add(this.cbSwitchOnCatchLimit);
            this.groupBox22.Location = new System.Drawing.Point(530, 8);
            this.groupBox22.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox22.Size = new System.Drawing.Size(226, 374);
            this.groupBox22.TabIndex = 22;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "Multi Bot Config";
            // 
            // tbCatchFleeCount
            // 
            this.tbCatchFleeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCatchFleeCount.Location = new System.Drawing.Point(156, 340);
            this.tbCatchFleeCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbCatchFleeCount.Name = "tbCatchFleeCount";
            this.tbCatchFleeCount.Size = new System.Drawing.Size(60, 23);
            this.tbCatchFleeCount.TabIndex = 36;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(8, 342);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(101, 15);
            this.label78.TabIndex = 35;
            this.label78.Text = "Catch Flee Count:";
            // 
            // cbSelectAccountOnStartUp
            // 
            this.cbSelectAccountOnStartUp.AutoSize = true;
            this.cbSelectAccountOnStartUp.Location = new System.Drawing.Point(10, 318);
            this.cbSelectAccountOnStartUp.Margin = new System.Windows.Forms.Padding(2);
            this.cbSelectAccountOnStartUp.Name = "cbSelectAccountOnStartUp";
            this.cbSelectAccountOnStartUp.Size = new System.Drawing.Size(169, 19);
            this.cbSelectAccountOnStartUp.TabIndex = 34;
            this.cbSelectAccountOnStartUp.Text = "Select Account On Start Up";
            this.cbSelectAccountOnStartUp.UseVisualStyleBackColor = true;
            // 
            // cbDisplayList
            // 
            this.cbDisplayList.AutoSize = true;
            this.cbDisplayList.Location = new System.Drawing.Point(10, 292);
            this.cbDisplayList.Margin = new System.Windows.Forms.Padding(2);
            this.cbDisplayList.Name = "cbDisplayList";
            this.cbDisplayList.Size = new System.Drawing.Size(85, 19);
            this.cbDisplayList.TabIndex = 33;
            this.cbDisplayList.Text = "Display List";
            this.cbDisplayList.UseVisualStyleBackColor = true;
            // 
            // tbPokestopSoftbanCount
            // 
            this.tbPokestopSoftbanCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPokestopSoftbanCount.Location = new System.Drawing.Point(156, 266);
            this.tbPokestopSoftbanCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbPokestopSoftbanCount.Name = "tbPokestopSoftbanCount";
            this.tbPokestopSoftbanCount.Size = new System.Drawing.Size(60, 23);
            this.tbPokestopSoftbanCount.TabIndex = 32;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(8, 267);
            this.label77.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(139, 15);
            this.label77.TabIndex = 31;
            this.label77.Text = "Pokestop Softban Count:";
            // 
            // cbStartFromDefaultLocation
            // 
            this.cbStartFromDefaultLocation.AutoSize = true;
            this.cbStartFromDefaultLocation.Location = new System.Drawing.Point(10, 242);
            this.cbStartFromDefaultLocation.Margin = new System.Windows.Forms.Padding(2);
            this.cbStartFromDefaultLocation.Name = "cbStartFromDefaultLocation";
            this.cbStartFromDefaultLocation.Size = new System.Drawing.Size(171, 19);
            this.cbStartFromDefaultLocation.TabIndex = 30;
            this.cbStartFromDefaultLocation.Text = "Start From Default Location";
            this.cbStartFromDefaultLocation.UseVisualStyleBackColor = true;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(8, 142);
            this.label73.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(68, 15);
            this.label73.TabIndex = 22;
            this.label73.Text = "EXP Switch:";
            // 
            // tbEXPSwitch
            // 
            this.tbEXPSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEXPSwitch.Location = new System.Drawing.Point(156, 140);
            this.tbEXPSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbEXPSwitch.Name = "tbEXPSwitch";
            this.tbEXPSwitch.Size = new System.Drawing.Size(60, 23);
            this.tbEXPSwitch.TabIndex = 26;
            // 
            // tbPokestopSwitch
            // 
            this.tbPokestopSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPokestopSwitch.Enabled = false;
            this.tbPokestopSwitch.Location = new System.Drawing.Point(156, 166);
            this.tbPokestopSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbPokestopSwitch.Name = "tbPokestopSwitch";
            this.tbPokestopSwitch.Size = new System.Drawing.Size(60, 23);
            this.tbPokestopSwitch.TabIndex = 27;
            // 
            // tbPokemonPerHourSwitch
            // 
            this.tbPokemonPerHourSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPokemonPerHourSwitch.Location = new System.Drawing.Point(156, 214);
            this.tbPokemonPerHourSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbPokemonPerHourSwitch.Name = "tbPokemonPerHourSwitch";
            this.tbPokemonPerHourSwitch.Size = new System.Drawing.Size(60, 23);
            this.tbPokemonPerHourSwitch.TabIndex = 28;
            // 
            // tbPokemonSwitch
            // 
            this.tbPokemonSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPokemonSwitch.Enabled = false;
            this.tbPokemonSwitch.Location = new System.Drawing.Point(156, 190);
            this.tbPokemonSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbPokemonSwitch.Name = "tbPokemonSwitch";
            this.tbPokemonSwitch.Size = new System.Drawing.Size(60, 23);
            this.tbPokemonSwitch.TabIndex = 29;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(8, 217);
            this.label76.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(149, 15);
            this.label76.TabIndex = 25;
            this.label76.Text = "Pokemon Per Hour Switch:";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(8, 117);
            this.label72.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(98, 15);
            this.label72.TabIndex = 20;
            this.label72.Text = "Min IV To Switch:";
            // 
            // tbMinIVToSwitch
            // 
            this.tbMinIVToSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinIVToSwitch.Location = new System.Drawing.Point(156, 114);
            this.tbMinIVToSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbMinIVToSwitch.Name = "tbMinIVToSwitch";
            this.tbMinIVToSwitch.Size = new System.Drawing.Size(60, 23);
            this.tbMinIVToSwitch.TabIndex = 21;
            // 
            // cbOnRarePokemon
            // 
            this.cbOnRarePokemon.AutoSize = true;
            this.cbOnRarePokemon.Location = new System.Drawing.Point(10, 92);
            this.cbOnRarePokemon.Margin = new System.Windows.Forms.Padding(2);
            this.cbOnRarePokemon.Name = "cbOnRarePokemon";
            this.cbOnRarePokemon.Size = new System.Drawing.Size(160, 19);
            this.cbOnRarePokemon.TabIndex = 19;
            this.cbOnRarePokemon.Text = "Switch On Rare Pokemon";
            this.cbOnRarePokemon.UseVisualStyleBackColor = true;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(6, 17);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(93, 15);
            this.label69.TabIndex = 6;
            this.label69.Text = "Runtime Switch:";
            // 
            // tbRuntimeSwitch
            // 
            this.tbRuntimeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRuntimeSwitch.Location = new System.Drawing.Point(154, 14);
            this.tbRuntimeSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tbRuntimeSwitch.Name = "tbRuntimeSwitch";
            this.tbRuntimeSwitch.Size = new System.Drawing.Size(60, 23);
            this.tbRuntimeSwitch.TabIndex = 9;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(6, 42);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(127, 15);
            this.label70.TabIndex = 7;
            this.label70.Text = "Runtime Random Min:";
            // 
            // tbRuntimeSwitchRandomTime
            // 
            this.tbRuntimeSwitchRandomTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRuntimeSwitchRandomTime.Location = new System.Drawing.Point(154, 40);
            this.tbRuntimeSwitchRandomTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbRuntimeSwitchRandomTime.Name = "tbRuntimeSwitchRandomTime";
            this.tbRuntimeSwitchRandomTime.Size = new System.Drawing.Size(60, 23);
            this.tbRuntimeSwitchRandomTime.TabIndex = 10;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(6, 67);
            this.label71.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(125, 15);
            this.label71.TabIndex = 8;
            this.label71.Text = "On Limit Pause Times:";
            // 
            // tbOnLimitPauseTimes
            // 
            this.tbOnLimitPauseTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOnLimitPauseTimes.Location = new System.Drawing.Point(154, 66);
            this.tbOnLimitPauseTimes.Margin = new System.Windows.Forms.Padding(2);
            this.tbOnLimitPauseTimes.Name = "tbOnLimitPauseTimes";
            this.tbOnLimitPauseTimes.Size = new System.Drawing.Size(60, 23);
            this.tbOnLimitPauseTimes.TabIndex = 11;
            // 
            // cbSwitchOnPokestopLimit
            // 
            this.cbSwitchOnPokestopLimit.AutoSize = true;
            this.cbSwitchOnPokestopLimit.Location = new System.Drawing.Point(10, 166);
            this.cbSwitchOnPokestopLimit.Margin = new System.Windows.Forms.Padding(2);
            this.cbSwitchOnPokestopLimit.Name = "cbSwitchOnPokestopLimit";
            this.cbSwitchOnPokestopLimit.Size = new System.Drawing.Size(140, 19);
            this.cbSwitchOnPokestopLimit.TabIndex = 38;
            this.cbSwitchOnPokestopLimit.Text = "Switch On Stop Limit:";
            this.cbSwitchOnPokestopLimit.UseVisualStyleBackColor = true;
            // 
            // cbSwitchOnCatchLimit
            // 
            this.cbSwitchOnCatchLimit.AutoSize = true;
            this.cbSwitchOnCatchLimit.Location = new System.Drawing.Point(10, 190);
            this.cbSwitchOnCatchLimit.Margin = new System.Windows.Forms.Padding(2);
            this.cbSwitchOnCatchLimit.Name = "cbSwitchOnCatchLimit";
            this.cbSwitchOnCatchLimit.Size = new System.Drawing.Size(147, 19);
            this.cbSwitchOnCatchLimit.TabIndex = 37;
            this.cbSwitchOnCatchLimit.Text = "Switch On Catch Limit:";
            this.cbSwitchOnCatchLimit.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label32);
            this.groupBox19.Controls.Add(this.tbAutoWalkKM);
            this.groupBox19.Controls.Add(this.cbAutoWalkAI);
            this.groupBox19.Location = new System.Drawing.Point(8, 288);
            this.groupBox19.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox19.Size = new System.Drawing.Size(250, 74);
            this.groupBox19.TabIndex = 21;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Auto Walk AI";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 42);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 15);
            this.label32.TabIndex = 20;
            this.label32.Text = "AI Distance(Km):";
            // 
            // tbAutoWalkKM
            // 
            this.tbAutoWalkKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAutoWalkKM.Location = new System.Drawing.Point(180, 40);
            this.tbAutoWalkKM.Margin = new System.Windows.Forms.Padding(2);
            this.tbAutoWalkKM.Name = "tbAutoWalkKM";
            this.tbAutoWalkKM.Size = new System.Drawing.Size(60, 23);
            this.tbAutoWalkKM.TabIndex = 21;
            // 
            // cbAutoWalkAI
            // 
            this.cbAutoWalkAI.AutoSize = true;
            this.cbAutoWalkAI.Location = new System.Drawing.Point(10, 18);
            this.cbAutoWalkAI.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoWalkAI.Name = "cbAutoWalkAI";
            this.cbAutoWalkAI.Size = new System.Drawing.Size(127, 19);
            this.cbAutoWalkAI.TabIndex = 19;
            this.cbAutoWalkAI.Text = "Enable AutoWalkAI";
            this.cbAutoWalkAI.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.cbRandomizeRecycle);
            this.groupBox17.Controls.Add(this.label51);
            this.groupBox17.Controls.Add(this.tbRandomRecycleValue);
            this.groupBox17.Location = new System.Drawing.Point(266, 254);
            this.groupBox17.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox17.Size = new System.Drawing.Size(254, 74);
            this.groupBox17.TabIndex = 19;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Recycle Behavior";
            // 
            // cbRandomizeRecycle
            // 
            this.cbRandomizeRecycle.AutoSize = true;
            this.cbRandomizeRecycle.Location = new System.Drawing.Point(10, 18);
            this.cbRandomizeRecycle.Margin = new System.Windows.Forms.Padding(2);
            this.cbRandomizeRecycle.Name = "cbRandomizeRecycle";
            this.cbRandomizeRecycle.Size = new System.Drawing.Size(128, 19);
            this.cbRandomizeRecycle.TabIndex = 17;
            this.cbRandomizeRecycle.Text = "Randomize Recycle";
            this.cbRandomizeRecycle.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(6, 42);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(129, 15);
            this.label51.TabIndex = 14;
            this.label51.Text = "Random Recycle Value:";
            // 
            // tbRandomRecycleValue
            // 
            this.tbRandomRecycleValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRandomRecycleValue.Location = new System.Drawing.Point(186, 40);
            this.tbRandomRecycleValue.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbRandomRecycleValue.Name = "tbRandomRecycleValue";
            this.tbRandomRecycleValue.Size = new System.Drawing.Size(60, 23);
            this.tbRandomRecycleValue.TabIndex = 15;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.tbWalkingSpeedVariantInKilometerPerHour);
            this.groupBox16.Controls.Add(this.cbStartFromLastPosition);
            this.groupBox16.Controls.Add(this.cbShowWalkingSpeed);
            this.groupBox16.Controls.Add(this.cbUseWalkingSpeedVariant);
            this.groupBox16.Controls.Add(this.cbDisableHumanWalking);
            this.groupBox16.Controls.Add(this.label57);
            this.groupBox16.Controls.Add(this.label58);
            this.groupBox16.Controls.Add(this.tbMaxSpawnLocationOffset);
            this.groupBox16.Controls.Add(this.label59);
            this.groupBox16.Controls.Add(this.tbMaxTravelDistanceInMeters);
            this.groupBox16.Location = new System.Drawing.Point(8, 8);
            this.groupBox16.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox16.Size = new System.Drawing.Size(250, 190);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Walking Behavior";
            // 
            // tbWalkingSpeedVariantInKilometerPerHour
            // 
            this.tbWalkingSpeedVariantInKilometerPerHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWalkingSpeedVariantInKilometerPerHour.Location = new System.Drawing.Point(180, 66);
            this.tbWalkingSpeedVariantInKilometerPerHour.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbWalkingSpeedVariantInKilometerPerHour.Name = "tbWalkingSpeedVariantInKilometerPerHour";
            this.tbWalkingSpeedVariantInKilometerPerHour.Size = new System.Drawing.Size(60, 23);
            this.tbWalkingSpeedVariantInKilometerPerHour.TabIndex = 15;
            // 
            // cbStartFromLastPosition
            // 
            this.cbStartFromLastPosition.AutoSize = true;
            this.cbStartFromLastPosition.BackColor = System.Drawing.Color.Transparent;
            this.cbStartFromLastPosition.Location = new System.Drawing.Point(10, 166);
            this.cbStartFromLastPosition.Margin = new System.Windows.Forms.Padding(2);
            this.cbStartFromLastPosition.Name = "cbStartFromLastPosition";
            this.cbStartFromLastPosition.Size = new System.Drawing.Size(142, 19);
            this.cbStartFromLastPosition.TabIndex = 31;
            this.cbStartFromLastPosition.Text = "StartFromLastPosition";
            this.cbStartFromLastPosition.UseVisualStyleBackColor = false;
            // 
            // cbShowWalkingSpeed
            // 
            this.cbShowWalkingSpeed.AutoSize = true;
            this.cbShowWalkingSpeed.Location = new System.Drawing.Point(10, 92);
            this.cbShowWalkingSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowWalkingSpeed.Name = "cbShowWalkingSpeed";
            this.cbShowWalkingSpeed.Size = new System.Drawing.Size(136, 19);
            this.cbShowWalkingSpeed.TabIndex = 18;
            this.cbShowWalkingSpeed.Text = "Show Walking Speed";
            this.cbShowWalkingSpeed.UseVisualStyleBackColor = true;
            // 
            // cbUseWalkingSpeedVariant
            // 
            this.cbUseWalkingSpeedVariant.AutoSize = true;
            this.cbUseWalkingSpeedVariant.Location = new System.Drawing.Point(10, 42);
            this.cbUseWalkingSpeedVariant.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseWalkingSpeedVariant.Name = "cbUseWalkingSpeedVariant";
            this.cbUseWalkingSpeedVariant.Size = new System.Drawing.Size(165, 19);
            this.cbUseWalkingSpeedVariant.TabIndex = 17;
            this.cbUseWalkingSpeedVariant.Text = "Use Walking Speed Variant";
            this.cbUseWalkingSpeedVariant.UseVisualStyleBackColor = true;
            // 
            // cbDisableHumanWalking
            // 
            this.cbDisableHumanWalking.AutoSize = true;
            this.cbDisableHumanWalking.Location = new System.Drawing.Point(10, 18);
            this.cbDisableHumanWalking.Margin = new System.Windows.Forms.Padding(2);
            this.cbDisableHumanWalking.Name = "cbDisableHumanWalking";
            this.cbDisableHumanWalking.Size = new System.Drawing.Size(153, 19);
            this.cbDisableHumanWalking.TabIndex = 16;
            this.cbDisableHumanWalking.Text = "Disable Human Walking";
            this.cbDisableHumanWalking.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(10, 67);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(170, 15);
            this.label57.TabIndex = 14;
            this.label57.Text = "Walking Speed Variant (KM/H):";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(10, 117);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(154, 15);
            this.label58.TabIndex = 14;
            this.label58.Text = "Max Spawn Location Offset:";
            // 
            // tbMaxSpawnLocationOffset
            // 
            this.tbMaxSpawnLocationOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxSpawnLocationOffset.Location = new System.Drawing.Point(180, 114);
            this.tbMaxSpawnLocationOffset.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbMaxSpawnLocationOffset.Name = "tbMaxSpawnLocationOffset";
            this.tbMaxSpawnLocationOffset.Size = new System.Drawing.Size(60, 23);
            this.tbMaxSpawnLocationOffset.TabIndex = 15;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(10, 142);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(161, 15);
            this.label59.TabIndex = 14;
            this.label59.Text = "Max Travel Distance (Meters):";
            // 
            // tbMaxTravelDistanceInMeters
            // 
            this.tbMaxTravelDistanceInMeters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxTravelDistanceInMeters.Location = new System.Drawing.Point(180, 140);
            this.tbMaxTravelDistanceInMeters.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbMaxTravelDistanceInMeters.Name = "tbMaxTravelDistanceInMeters";
            this.tbMaxTravelDistanceInMeters.Size = new System.Drawing.Size(60, 23);
            this.tbMaxTravelDistanceInMeters.TabIndex = 15;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.cbUseHumanlikeDelays);
            this.groupBox15.Controls.Add(this.label49);
            this.groupBox15.Controls.Add(this.tbDelayBetweenPlayerActions);
            this.groupBox15.Controls.Add(this.label50);
            this.groupBox15.Controls.Add(this.tbDelayBetweenPokemonCatch);
            this.groupBox15.Location = new System.Drawing.Point(8, 198);
            this.groupBox15.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox15.Size = new System.Drawing.Size(250, 90);
            this.groupBox15.TabIndex = 18;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Action Behavior";
            // 
            // cbUseHumanlikeDelays
            // 
            this.cbUseHumanlikeDelays.AutoSize = true;
            this.cbUseHumanlikeDelays.Location = new System.Drawing.Point(10, 66);
            this.cbUseHumanlikeDelays.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseHumanlikeDelays.Name = "cbUseHumanlikeDelays";
            this.cbUseHumanlikeDelays.Size = new System.Drawing.Size(137, 19);
            this.cbUseHumanlikeDelays.TabIndex = 16;
            this.cbUseHumanlikeDelays.Text = "UseHumanlikeDelays";
            this.cbUseHumanlikeDelays.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(10, 17);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(157, 15);
            this.label49.TabIndex = 14;
            this.label49.Text = "Delay Between Actions (ms):";
            // 
            // tbDelayBetweenPlayerActions
            // 
            this.tbDelayBetweenPlayerActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDelayBetweenPlayerActions.Location = new System.Drawing.Point(180, 14);
            this.tbDelayBetweenPlayerActions.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbDelayBetweenPlayerActions.Name = "tbDelayBetweenPlayerActions";
            this.tbDelayBetweenPlayerActions.Size = new System.Drawing.Size(60, 23);
            this.tbDelayBetweenPlayerActions.TabIndex = 15;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(10, 42);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(165, 15);
            this.label50.TabIndex = 14;
            this.label50.Text = "Delay Between Catching (ms):";
            // 
            // tbDelayBetweenPokemonCatch
            // 
            this.tbDelayBetweenPokemonCatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDelayBetweenPokemonCatch.Location = new System.Drawing.Point(180, 40);
            this.tbDelayBetweenPokemonCatch.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.tbDelayBetweenPokemonCatch.Name = "tbDelayBetweenPokemonCatch";
            this.tbDelayBetweenPokemonCatch.Size = new System.Drawing.Size(60, 23);
            this.tbDelayBetweenPokemonCatch.TabIndex = 15;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.cbEnableHumanizedThrows);
            this.groupBox18.Controls.Add(this.tbForceExcellentThrowOverCp);
            this.groupBox18.Controls.Add(this.tbForceGreatThrowOverCp);
            this.groupBox18.Controls.Add(this.label66);
            this.groupBox18.Controls.Add(this.label55);
            this.groupBox18.Controls.Add(this.label60);
            this.groupBox18.Controls.Add(this.tbForceExcellentThrowOverIv);
            this.groupBox18.Controls.Add(this.tbNiceThrowChance);
            this.groupBox18.Controls.Add(this.label61);
            this.groupBox18.Controls.Add(this.label62);
            this.groupBox18.Controls.Add(this.tbForceGreatThrowOverIv);
            this.groupBox18.Controls.Add(this.tbGreatThrowChance);
            this.groupBox18.Controls.Add(this.label63);
            this.groupBox18.Controls.Add(this.label64);
            this.groupBox18.Controls.Add(this.tbCurveThrowChance);
            this.groupBox18.Controls.Add(this.tbExcellentThrowChance);
            this.groupBox18.Controls.Add(this.label65);
            this.groupBox18.Location = new System.Drawing.Point(266, 8);
            this.groupBox18.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox18.Size = new System.Drawing.Size(254, 246);
            this.groupBox18.TabIndex = 20;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Catching Behavior";
            // 
            // cbEnableHumanizedThrows
            // 
            this.cbEnableHumanizedThrows.AutoSize = true;
            this.cbEnableHumanizedThrows.Location = new System.Drawing.Point(10, 18);
            this.cbEnableHumanizedThrows.Margin = new System.Windows.Forms.Padding(2);
            this.cbEnableHumanizedThrows.Name = "cbEnableHumanizedThrows";
            this.cbEnableHumanizedThrows.Size = new System.Drawing.Size(167, 19);
            this.cbEnableHumanizedThrows.TabIndex = 18;
            this.cbEnableHumanizedThrows.Text = "Enable Humanized Throws";
            this.cbEnableHumanizedThrows.UseVisualStyleBackColor = true;
            // 
            // tbForceExcellentThrowOverCp
            // 
            this.tbForceExcellentThrowOverCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForceExcellentThrowOverCp.Location = new System.Drawing.Point(186, 214);
            this.tbForceExcellentThrowOverCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbForceExcellentThrowOverCp.Name = "tbForceExcellentThrowOverCp";
            this.tbForceExcellentThrowOverCp.Size = new System.Drawing.Size(60, 23);
            this.tbForceExcellentThrowOverCp.TabIndex = 5;
            // 
            // tbForceGreatThrowOverCp
            // 
            this.tbForceGreatThrowOverCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForceGreatThrowOverCp.Location = new System.Drawing.Point(186, 190);
            this.tbForceGreatThrowOverCp.Margin = new System.Windows.Forms.Padding(2);
            this.tbForceGreatThrowOverCp.Name = "tbForceGreatThrowOverCp";
            this.tbForceGreatThrowOverCp.Size = new System.Drawing.Size(60, 23);
            this.tbForceGreatThrowOverCp.TabIndex = 5;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(6, 217);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(171, 15);
            this.label66.TabIndex = 4;
            this.label66.Text = "Force Excellent Throw Over CP:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(6, 191);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(153, 15);
            this.label55.TabIndex = 4;
            this.label55.Text = "Force Great Throw Over CP:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(6, 42);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(127, 15);
            this.label60.TabIndex = 4;
            this.label60.Text = "Nice Throw Chance %:";
            // 
            // tbForceExcellentThrowOverIv
            // 
            this.tbForceExcellentThrowOverIv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForceExcellentThrowOverIv.Location = new System.Drawing.Point(186, 166);
            this.tbForceExcellentThrowOverIv.Margin = new System.Windows.Forms.Padding(2);
            this.tbForceExcellentThrowOverIv.Name = "tbForceExcellentThrowOverIv";
            this.tbForceExcellentThrowOverIv.Size = new System.Drawing.Size(60, 23);
            this.tbForceExcellentThrowOverIv.TabIndex = 5;
            // 
            // tbNiceThrowChance
            // 
            this.tbNiceThrowChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNiceThrowChance.Location = new System.Drawing.Point(186, 40);
            this.tbNiceThrowChance.Margin = new System.Windows.Forms.Padding(2);
            this.tbNiceThrowChance.Name = "tbNiceThrowChance";
            this.tbNiceThrowChance.Size = new System.Drawing.Size(60, 23);
            this.tbNiceThrowChance.TabIndex = 5;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(6, 167);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(179, 15);
            this.label61.TabIndex = 4;
            this.label61.Text = "Force Excellent Throw Over IV %:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(6, 67);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(131, 15);
            this.label62.TabIndex = 4;
            this.label62.Text = "Great Throw Chance %:";
            // 
            // tbForceGreatThrowOverIv
            // 
            this.tbForceGreatThrowOverIv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbForceGreatThrowOverIv.Location = new System.Drawing.Point(186, 140);
            this.tbForceGreatThrowOverIv.Margin = new System.Windows.Forms.Padding(2);
            this.tbForceGreatThrowOverIv.Name = "tbForceGreatThrowOverIv";
            this.tbForceGreatThrowOverIv.Size = new System.Drawing.Size(60, 23);
            this.tbForceGreatThrowOverIv.TabIndex = 5;
            // 
            // tbGreatThrowChance
            // 
            this.tbGreatThrowChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGreatThrowChance.Location = new System.Drawing.Point(186, 66);
            this.tbGreatThrowChance.Margin = new System.Windows.Forms.Padding(2);
            this.tbGreatThrowChance.Name = "tbGreatThrowChance";
            this.tbGreatThrowChance.Size = new System.Drawing.Size(60, 23);
            this.tbGreatThrowChance.TabIndex = 5;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(6, 142);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(161, 15);
            this.label63.TabIndex = 4;
            this.label63.Text = "Force Great Throw Over IV %:\r\n";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(6, 91);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(149, 15);
            this.label64.TabIndex = 4;
            this.label64.Text = "Excellent Throw Chance %:\r\n";
            // 
            // tbCurveThrowChance
            // 
            this.tbCurveThrowChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCurveThrowChance.Location = new System.Drawing.Point(186, 114);
            this.tbCurveThrowChance.Margin = new System.Windows.Forms.Padding(2);
            this.tbCurveThrowChance.Name = "tbCurveThrowChance";
            this.tbCurveThrowChance.Size = new System.Drawing.Size(60, 23);
            this.tbCurveThrowChance.TabIndex = 5;
            // 
            // tbExcellentThrowChance
            // 
            this.tbExcellentThrowChance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExcellentThrowChance.Location = new System.Drawing.Point(186, 90);
            this.tbExcellentThrowChance.Margin = new System.Windows.Forms.Padding(2);
            this.tbExcellentThrowChance.Name = "tbExcellentThrowChance";
            this.tbExcellentThrowChance.Size = new System.Drawing.Size(60, 23);
            this.tbExcellentThrowChance.TabIndex = 5;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(6, 117);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(134, 15);
            this.label65.TabIndex = 4;
            this.label65.Text = "Curve Throw Chance %:\r\n";
            // 
            // tabAuthJson
            // 
            this.tabAuthJson.Controls.Add(this.splitContainer2);
            this.tabAuthJson.Location = new System.Drawing.Point(4, 24);
            this.tabAuthJson.Margin = new System.Windows.Forms.Padding(2);
            this.tabAuthJson.Name = "tabAuthJson";
            this.tabAuthJson.Padding = new System.Windows.Forms.Padding(2);
            this.tabAuthJson.Size = new System.Drawing.Size(762, 386);
            this.tabAuthJson.TabIndex = 6;
            this.tabAuthJson.Text = "Auth & Config";
            this.tabAuthJson.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(2, 2);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(758, 382);
            this.splitContainer2.SplitterDistance = 375;
            this.splitContainer2.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.Auth);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Size = new System.Drawing.Size(375, 382);
            this.splitContainer4.SplitterDistance = 205;
            this.splitContainer4.TabIndex = 3;
            // 
            // Auth
            // 
            this.Auth.AllowDrop = true;
            this.Auth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Auth.LabelEdit = true;
            this.Auth.Location = new System.Drawing.Point(0, 0);
            this.Auth.Margin = new System.Windows.Forms.Padding(4);
            this.Auth.Name = "Auth";
            this.Auth.Size = new System.Drawing.Size(205, 382);
            this.Auth.TabIndex = 2;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.Config);
            this.splitContainer5.Size = new System.Drawing.Size(379, 382);
            this.splitContainer5.SplitterDistance = 208;
            this.splitContainer5.TabIndex = 3;
            // 
            // Config
            // 
            this.Config.AllowDrop = true;
            this.Config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Config.LabelEdit = true;
            this.Config.Location = new System.Drawing.Point(0, 0);
            this.Config.Margin = new System.Windows.Forms.Padding(4);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(208, 382);
            this.Config.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Location = new System.Drawing.Point(554, 416);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 50);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // cbAutoSniper
            // 
            this.cbAutoSniper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAutoSniper.AutoSize = true;
            this.cbAutoSniper.Location = new System.Drawing.Point(14, 418);
            this.cbAutoSniper.Margin = new System.Windows.Forms.Padding(2);
            this.cbAutoSniper.Name = "cbAutoSniper";
            this.cbAutoSniper.Size = new System.Drawing.Size(134, 19);
            this.cbAutoSniper.TabIndex = 33;
            this.cbAutoSniper.Text = "Activate Auto Sniper";
            this.cbAutoSniper.UseVisualStyleBackColor = true;
            // 
            // cbEnableGyms
            // 
            this.cbEnableGyms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnableGyms.AutoSize = true;
            this.cbEnableGyms.Location = new System.Drawing.Point(14, 444);
            this.cbEnableGyms.Margin = new System.Windows.Forms.Padding(2);
            this.cbEnableGyms.Name = "cbEnableGyms";
            this.cbEnableGyms.Size = new System.Drawing.Size(94, 19);
            this.cbEnableGyms.TabIndex = 34;
            this.cbEnableGyms.Text = "Enable Gmys";
            this.cbEnableGyms.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(152, 418);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(138, 15);
            this.label48.TabIndex = 35;
            this.label48.Text = "DataServiceIdentification";
            // 
            // tbDataServiceIdentification
            // 
            this.tbDataServiceIdentification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbDataServiceIdentification.Location = new System.Drawing.Point(294, 415);
            this.tbDataServiceIdentification.Margin = new System.Windows.Forms.Padding(2);
            this.tbDataServiceIdentification.Name = "tbDataServiceIdentification";
            this.tbDataServiceIdentification.Size = new System.Drawing.Size(178, 23);
            this.tbDataServiceIdentification.TabIndex = 36;
            // 
            // cbEnableSyncData
            // 
            this.cbEnableSyncData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEnableSyncData.AutoSize = true;
            this.cbEnableSyncData.Location = new System.Drawing.Point(294, 446);
            this.cbEnableSyncData.Margin = new System.Windows.Forms.Padding(2);
            this.cbEnableSyncData.Name = "cbEnableSyncData";
            this.cbEnableSyncData.Size = new System.Drawing.Size(110, 19);
            this.cbEnableSyncData.TabIndex = 37;
            this.cbEnableSyncData.Text = "EnableSyncData";
            this.cbEnableSyncData.UseVisualStyleBackColor = true;
            // 
            // cBoxTeamColor
            // 
            this.cBoxTeamColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxTeamColor.FormattingEnabled = true;
            this.cBoxTeamColor.Items.AddRange(new object[] {
            "Neutral",
            "Yellow",
            "Blue",
            "Red"});
            this.cBoxTeamColor.Location = new System.Drawing.Point(108, 443);
            this.cBoxTeamColor.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxTeamColor.Name = "cBoxTeamColor";
            this.cBoxTeamColor.Size = new System.Drawing.Size(80, 23);
            this.cBoxTeamColor.TabIndex = 38;
            this.cBoxTeamColor.Text = "Neutral";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(774, 470);
            this.Controls.Add(this.cBoxTeamColor);
            this.Controls.Add(this.cbEnableSyncData);
            this.Controls.Add(this.tbDataServiceIdentification);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.cbEnableGyms);
            this.Controls.Add(this.cbAutoSniper);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.saveBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RocketBot2 Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPosition.ResumeLayout(false);
            this.tabPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tabDevice.ResumeLayout(false);
            this.tabDevice.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tabAPIConfig.ResumeLayout(false);
            this.tabAPIConfig.PerformLayout();
            this.tabAccounts.ResumeLayout(false);
            this.proxyGb.ResumeLayout(false);
            this.proxyGb.PerformLayout();
            this.tabPokemon.ResumeLayout(false);
            this.tcPokemonDetail.ResumeLayout(false);
            this.tabCatch.ResumeLayout(false);
            this.tabCatch.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox25.ResumeLayout(false);
            this.groupBox25.PerformLayout();
            this.groupBox23.ResumeLayout(false);
            this.groupBox23.PerformLayout();
            this.groupBox24.ResumeLayout(false);
            this.groupBox24.PerformLayout();
            this.gbCatchIgnore.ResumeLayout(false);
            this.gbCatchIgnore.PerformLayout();
            this.gbCatchPokemon.ResumeLayout(false);
            this.gbCatchPokemon.PerformLayout();
            this.tabTransfer.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbExcludeTrans.ResumeLayout(false);
            this.gbExcludeTrans.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPowerUp.ResumeLayout(false);
            this.tabPowerUp.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbPUP.ResumeLayout(false);
            this.gbPUP.PerformLayout();
            this.tabEvo.ResumeLayout(false);
            this.tabEvo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbEvolve.ResumeLayout(false);
            this.tabSnipePokemonFilter.ResumeLayout(false);
            this.gbSnipe.ResumeLayout(false);
            this.gbSnipe.PerformLayout();
            this.tabItems.ResumeLayout(false);
            this.tabItems.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabAdvSetting.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.tabAuthJson.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAuth;
        private System.Windows.Forms.TextBox tbWalkingSpeed;
        private System.Windows.Forms.Label TravelSpeedText;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox proxyGb;
        private System.Windows.Forms.TextBox proxyPortTb;
        private System.Windows.Forms.TextBox proxyUserTb;
        private System.Windows.Forms.TextBox proxyPwTb;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox proxyHostTb;
        private System.Windows.Forms.CheckBox useProxyAuthCb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox useProxyCb;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button ResetLocationBtn;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Button FindAdressBtn;
        private GMap.NET.WindowsForms.GMapControl gMapCtrl;
        private System.Windows.Forms.TextBox UserLoginBox;
        private System.Windows.Forms.TextBox UserPasswordBox;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.Label authTypeLabel;
        private System.Windows.Forms.Label longiLabel;
        private System.Windows.Forms.ComboBox authTypeCb;
        private System.Windows.Forms.Label latLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button RandomIDBtn;
        private System.Windows.Forms.ComboBox deviceTypeCb;
        private System.Windows.Forms.Button RandomDeviceBtn;
        private System.Windows.Forms.TextBox FirmwareFingerprintTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox FirmwareTypeTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox FirmwareTagsTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FirmwareBrandTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox HardwareModelTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HardwareManufacturerTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DeviceModelBootTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DeviceModelIdentifierTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DeviceModelTb;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DeviceBrandTb;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox AndroidBootloaderTb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AndroidBoardNameTb;
        private System.Windows.Forms.Label BoardName;
        private System.Windows.Forms.TextBox DeviceIdTb;
        private System.Windows.Forms.Label deviceIdlb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPokemon;
        private System.Windows.Forms.TabControl tcPokemonDetail;
        private System.Windows.Forms.TabPage tabCatch;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.CheckBox cbAutoFavoritePokemon;
        private System.Windows.Forms.TextBox tbFavoriteMinIvPercentage;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox cbUseBerriesOperator;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbUseBerriesMinCp;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox tbUseBerriesMinIv;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tbUseBerriesBelowCatchProbability;
        private System.Windows.Forms.TextBox tbMaxPokeballsPerPokemon;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUseMasterBallBelowCatchProbability;
        private System.Windows.Forms.TextBox tbUseGreatBallAboveCp;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUseUltraBallBelowCatchProbability;
        private System.Windows.Forms.TextBox tbUseUltraBallAboveCp;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUseGreatBallBelowCatchProbability;
        private System.Windows.Forms.TextBox tbUseMasterBallAboveCp;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUseUltraBallAboveIv;
        private System.Windows.Forms.TextBox tbUseGreatBallAboveIv;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.GroupBox gbCatchIgnore;
        private System.Windows.Forms.CheckBox cbIgnoreAll;
        private System.Windows.Forms.CheckedListBox clbCatchIgnore;
        private System.Windows.Forms.TextBox tBMaxBerriesToUsePerPokemon;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbUseEggIncubators;
        private System.Windows.Forms.CheckBox cbCatchPoke;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.GroupBox gbExcludeTrans;
        private System.Windows.Forms.CheckBox cbNotTransferAll;
        private System.Windows.Forms.CheckedListBox clbTransfer;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cbUseKeepMinLvl;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbKeepMinLvl;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbTransferDuplicatePokemonOnCapture;
        private System.Windows.Forms.CheckBox cbTransferDuplicatePokemon;
        private System.Windows.Forms.CheckBox cbTransferWeakPokemon;
        private System.Windows.Forms.TextBox tbKeepMinDuplicatePokemon;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cbPrioritizeIvOverCp;
        private System.Windows.Forms.TextBox tbKeepMinIV;
        private System.Windows.Forms.ComboBox cbKeepMinOperator;
        private System.Windows.Forms.TextBox tbKeepMinCp;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabPowerUp;
        private System.Windows.Forms.CheckBox cbPowerUpFav;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbPowerUpMinIV;
        private System.Windows.Forms.ComboBox cbPowerUpCondiction;
        private System.Windows.Forms.TextBox tbPowerUpMinCP;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbPowerUpMinStarDust;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cbPowerUpType;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox gbPUP;
        private System.Windows.Forms.CheckBox cbPowerUpAll;
        private System.Windows.Forms.CheckedListBox clbPowerUp;
        private System.Windows.Forms.CheckBox cbAutoPowerUp;
        private System.Windows.Forms.TabPage tabEvo;
        private System.Windows.Forms.TextBox tbEvolveApplyLuckyEggOnEvolutionCountValue;
        private System.Windows.Forms.CheckBox cbEvolveApplyLuckyEggOnEvolutionCount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbTriggerEvolveAsSoonAsFilterIsMatched;
        private System.Windows.Forms.CheckBox cbTriggerEvolveOnEvolutionCount;
        private System.Windows.Forms.TextBox tbTriggerEvolveOnEvolutionCountValue;
        private System.Windows.Forms.CheckBox cbTriggerEvolveOnStorageUsagePercentage;
        private System.Windows.Forms.GroupBox gbEvolve;
        private System.Windows.Forms.CheckBox cbEvolveAll;
        private System.Windows.Forms.CheckedListBox clbEvolve;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotalAmountOfPokeballsToKeep;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbTotalAmountOfPotionsToKeep;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbTotalAmountOfRevivesToKeep;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbTotalAmountOfBerriesToKeep;
        private System.Windows.Forms.CheckBox cbUseIncenseConstantly;
        private System.Windows.Forms.CheckBox cbUseLuckyEggConstantly;
        private System.Windows.Forms.TabPage tabAdvSetting;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox cbVerboseRecycling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRecycleInventoryAtUsagePercentage;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox cbDisableHumanWalking;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tbWalkingSpeedVariantInKilometerPerHour;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tbMaxSpawnLocationOffset;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox tbMaxTravelDistanceInMeters;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tbDelayBetweenPlayerActions;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tbDelayBetweenPokemonCatch;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.CheckBox cbRandomizeRecycle;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tbRandomRecycleValue;
        private System.Windows.Forms.TextBox GoogleApiBox;
        private System.Windows.Forms.Label GoogleApiLabel;
        private System.Windows.Forms.CheckBox cbShowWalkingSpeed;
        private System.Windows.Forms.CheckBox cbUseWalkingSpeedVariant;
        private System.Windows.Forms.CheckBox cbAutoSniper;
        private System.Windows.Forms.CheckBox cbEnableGyms;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox tbDataServiceIdentification;
        private System.Windows.Forms.CheckBox cbUseHumanlikeDelays;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPosition;
        private System.Windows.Forms.TabPage tabDevice;
        private System.Windows.Forms.TabPage tabAPIConfig;
        private System.Windows.Forms.CheckBox cbDiplayHashServerLog;
        private System.Windows.Forms.CheckBox cbUseCustomAPI;
        private System.Windows.Forms.TextBox tbAuthAPIKey;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.CheckBox cbUsePogoDevAPI;
        private System.Windows.Forms.CheckBox cbEnableSyncData;
        private System.Windows.Forms.TabPage tabAuthJson;
        private System.Windows.Forms.TreeView Auth;
        private System.Windows.Forms.CheckBox cbAutoFavoriteShinyOnCatch;
        private System.Windows.Forms.CheckBox cbUseLimitedEggIncubators;
        private System.Windows.Forms.ComboBox cBoxTeamColor;
        private System.Windows.Forms.TabPage tabSnipePokemonFilter;
        private System.Windows.Forms.CheckBox cbSnipePokemonFilterAll;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox cbStartFromLastPosition;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TreeView Config;
        private System.Windows.Forms.CheckBox cbEnablePushBulletNotification;
        private System.Windows.Forms.TextBox tbPushBulletAPIKey;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.ListView lvAccounts;
        private System.Windows.Forms.ColumnHeader chEmail;
        private System.Windows.Forms.ColumnHeader chUsername;
        private System.Windows.Forms.ColumnHeader chAuthType;
        private System.Windows.Forms.GroupBox gbCatchPokemon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox gbSnipe;
        private System.Windows.Forms.CheckedListBox clbSnipePokemonFilter;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbAutoWalkKM;
        private System.Windows.Forms.CheckBox cbAutoWalkAI;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.CheckBox cbEnableHumanizedThrows;
        private System.Windows.Forms.TextBox tbForceExcellentThrowOverCp;
        private System.Windows.Forms.TextBox tbForceGreatThrowOverCp;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tbForceExcellentThrowOverIv;
        private System.Windows.Forms.TextBox tbNiceThrowChance;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox tbForceGreatThrowOverIv;
        private System.Windows.Forms.TextBox tbGreatThrowChance;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tbCurveThrowChance;
        private System.Windows.Forms.TextBox tbExcellentThrowChance;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.GroupBox groupBox25;
        private System.Windows.Forms.GroupBox groupBox23;
        private System.Windows.Forms.GroupBox groupBox24;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox tbCatchFleeCount;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.CheckBox cbSelectAccountOnStartUp;
        private System.Windows.Forms.CheckBox cbDisplayList;
        private System.Windows.Forms.TextBox tbPokestopSoftbanCount;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.CheckBox cbStartFromDefaultLocation;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.TextBox tbEXPSwitch;
        private System.Windows.Forms.TextBox tbPokestopSwitch;
        private System.Windows.Forms.TextBox tbPokemonPerHourSwitch;
        private System.Windows.Forms.TextBox tbPokemonSwitch;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.TextBox tbMinIVToSwitch;
        private System.Windows.Forms.CheckBox cbOnRarePokemon;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox tbRuntimeSwitch;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox tbRuntimeSwitchRandomTime;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox tbOnLimitPauseTimes;
        private System.Windows.Forms.CheckBox cbSwitchOnCatchLimit;
        private System.Windows.Forms.CheckBox cbSwitchOnPokestopLimit;
        private System.Windows.Forms.TextBox tbHashURL;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox tbEvolveAnyPokemonAboveIvValue;
        private System.Windows.Forms.CheckBox cbEvolveAnyPokemonAboveIv;
        private System.Windows.Forms.CheckBox cbTriggerEvolveIfLuckyEggIsActive;
        private System.Windows.Forms.TextBox tbTriggerEvolveOnStorageUsageAbsoluteValue;
        private System.Windows.Forms.CheckBox cbTriggerEvolveOnStorageUsageAbsolute;
        private System.Windows.Forms.TextBox tbTriggerEvolveOnStorageUsagePercentageValue;
        private System.Windows.Forms.CheckBox cbEvolvePreserveMinCandiesFromFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.CheckBox cbEvolvePokemonsThatMatchFilter;
        private System.Windows.Forms.CheckBox cbKeepPokemonsToBeEvolved;
    }
}