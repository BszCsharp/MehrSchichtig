using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace KundenManageApp
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class KundenGui : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.ComboBox combKunde;
		private System.Windows.Forms.TextBox txtKundenId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtVorname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGebDatum;
        private Button btn_insert;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public KundenGui()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnTest = new System.Windows.Forms.Button();
            this.combKunde = new System.Windows.Forms.ComboBox();
            this.txtKundenId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGebDatum = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(32, 64);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(248, 24);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = " Kunden anzeigen";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // combKunde
            // 
            this.combKunde.Location = new System.Drawing.Point(32, 96);
            this.combKunde.Name = "combKunde";
            this.combKunde.Size = new System.Drawing.Size(248, 21);
            this.combKunde.TabIndex = 2;
            // 
            // txtKundenId
            // 
            this.txtKundenId.Location = new System.Drawing.Point(128, 136);
            this.txtKundenId.Name = "txtKundenId";
            this.txtKundenId.Size = new System.Drawing.Size(152, 20);
            this.txtKundenId.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "KundenId";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 168);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vorname";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(128, 200);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(152, 20);
            this.txtVorname.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Geb.-Datum";
            // 
            // txtGebDatum
            // 
            this.txtGebDatum.Location = new System.Drawing.Point(128, 240);
            this.txtGebDatum.Name = "txtGebDatum";
            this.txtGebDatum.Size = new System.Drawing.Size(152, 20);
            this.txtGebDatum.TabIndex = 15;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(336, 67);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(150, 20);
            this.btn_insert.TabIndex = 16;
            this.btn_insert.Text = "Kunden aufnehmen";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // KundenGui
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(568, 349);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txtGebDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKundenId);
            this.Controls.Add(this.combKunde);
            this.Controls.Add(this.btnTest);
            this.Name = "KundenGui";
            this.Text = "Kundenverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new KundenGui());
		}

		private void btnTest_Click(object sender, System.EventArgs e)
		{
			KundenDataAccess.DataTransfer dtr = new KundenDataAccess.DataTransfer();
			ArrayList alKunde  = dtr.GetAlleKunden();
			combKunde.Items.Clear();
			combKunde.DataSource = alKunde;
			combKunde.DisplayMember= "KundenDaten";
			this.txtGebDatum.DataBindings.Add("Text",alKunde,"GebDatum");
			this.txtVorname.DataBindings.Add("Text",alKunde,"Vorname");
			this.txtKundenId.DataBindings.Add("Text",alKunde,"KundenID");
			this.txtName.DataBindings.Add("Text",alKunde,"Name");
		}

        private void btn_insert_Click(object sender, EventArgs e)
        {
            KundenDataAccess.Kunde ku = new KundenDataAccess.Kunde();
            ku.KundenId = txtKundenId.Text;
            ku.Name = txtName.Text;
            ku.Vorname = txtVorname.Text;
            ku.GebDatum = txtGebDatum.Text;
            ku.Insert();
            
        }

		

		
	}
}
