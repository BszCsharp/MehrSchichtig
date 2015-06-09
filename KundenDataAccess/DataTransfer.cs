using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Data.OleDb;


namespace KundenDataAccess
{
	/// <summary>
	/// Zusammenfassung für DataTransfer.
	/// </summary>
	public class DataTransfer : System.ComponentModel.Component
	{
		private System.Data.OleDb.OleDbConnection oleDbKunden;
		private System.Data.OleDb.OleDbCommand cmd_kunden_anz;
        private OleDbCommand cmd_kunden_insert;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DataTransfer(System.ComponentModel.IContainer container)
		{
			///
			/// Erforderlich für Windows.Forms Klassenkompositions-Designerunterstützung
			///
			container.Add(this);
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		public DataTransfer()
		{
			///
			/// Erforderlich für Windows.Forms Klassenkompositions-Designerunterstützung
			///
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		
			

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


		#region Vom Komponenten-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            this.oleDbKunden = new System.Data.OleDb.OleDbConnection();
            this.cmd_kunden_anz = new System.Data.OleDb.OleDbCommand();
            this.cmd_kunden_insert = new System.Data.OleDb.OleDbCommand();
            // 
            // oleDbKunden
            // 
            this.oleDbKunden.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\laptop_siemens\\c#_public\\KundenMa" +
                "nage_ado\\KundenDataAccess\\kunden.mdb";
            this.oleDbKunden.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbKunden_InfoMessage);
            // 
            // cmd_kunden_anz
            // 
            this.cmd_kunden_anz.CommandText = "SELECT     KundenID, Name, VName, GebDat\r\nFROM         Kunden";
            this.cmd_kunden_anz.Connection = this.oleDbKunden;
            // 
            // cmd_kunden_insert
            // 
            this.cmd_kunden_insert.CommandText = "INSERT INTO Kunden\r\n                      (KundenID, Name, VName, GebDat)\r\nVALUES" +
                "     (?, ?, ?, ?)";
            this.cmd_kunden_insert.Connection = this.oleDbKunden;
            this.cmd_kunden_insert.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("KundenID", System.Data.OleDb.OleDbType.WChar, 50, "KundenID"),
            new System.Data.OleDb.OleDbParameter("Name", System.Data.OleDb.OleDbType.WChar, 255, "Name"),
            new System.Data.OleDb.OleDbParameter("VName", System.Data.OleDb.OleDbType.WChar, 255, "VName"),
            new System.Data.OleDb.OleDbParameter("GebDat", System.Data.OleDb.OleDbType.WChar, 50, "GebDat")});

		}
		#endregion

		

		private ArrayList alKunde = new ArrayList();

		
		public ArrayList GetAlleKunden()
		{
			oleDbKunden.Open();
			OleDbDataReader drKunde = cmd_kunden_anz.ExecuteReader();
								
			
			while(drKunde.Read())
			{
								
				Kunde k = new Kunde();
				k.KundenId = drKunde.GetString(0);
				k.Name = drKunde.GetString(1);
				k.Vorname = drKunde.GetString(2);
				k.GebDatum = drKunde.GetString(3);
				
				alKunde.Add(k);
			}
			
			return alKunde;
			drKunde.Close();
		}

        internal void InsertKunde(Kunde k)
        {
            this.oleDbKunden.Open();
            this.cmd_kunden_insert.Parameters["KundenID"].Value = k.KundenId;
            this.cmd_kunden_insert.Parameters["Name"].Value = k.Name;
            this.cmd_kunden_insert.Parameters["VName"].Value = k.Vorname;
            this.cmd_kunden_insert.Parameters["GebDat"].Value = k.GebDatum;
            try
            {
                this.cmd_kunden_insert.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void oleDbKunden_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }



	}
}
