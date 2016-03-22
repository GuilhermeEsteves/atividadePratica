namespace AtividadePraticaWebApi
{
    partial class AtividadePraticaWebApi
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceAtividadePratica = new System.ServiceProcess.ServiceProcessInstaller();
            this.AtividadePratica = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceAtividadePratica
            // 
            this.serviceAtividadePratica.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceAtividadePratica.Password = null;
            this.serviceAtividadePratica.Username = null;
            this.serviceAtividadePratica.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceAtividadePratica_AfterInstall);
            // 
            // AtividadePratica
            // 
            this.AtividadePratica.ServiceName = "Service1";
            this.AtividadePratica.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.AtividadePratica.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.serviceInstaller1_AfterInstall);
            // 
            // AtividadePraticaWebApi
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceAtividadePratica,
            this.AtividadePratica});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceAtividadePratica;
        private System.ServiceProcess.ServiceInstaller AtividadePratica;
    }
}