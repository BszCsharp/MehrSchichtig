using System;

namespace KundenDataAccess
{
	/// <summary>
	/// Zusammenfassung für Class1.
	/// </summary>
	public class Kunde
	{
		string mKundenId;
		string mName;
		string mVorname;
		string mgebDatum;
		string mStrasse;
		string mPlz;
		string mOrt;


		public Kunde()
		{
			//
			// TODO: Fügen Sie hier die Konstruktorlogik hinzu
			//
		}

		public string KundenId
		{
			get
			{
				return mKundenId;
			}
			set
			{
				mKundenId = value;
			}
		}

		public string Name
		{
			get
			{
				return mName;
			}
			set
			{
				mName = value;
			}
		}

		public string Vorname
		{
			get
			{
				return mVorname;
			}
			set
			{
				mVorname = value;
			}
		}

		public string GebDatum
		{
			get
			{
				return mgebDatum ;
			}
			set
			{
				mgebDatum = value;
			}
		}

		
		public string KundenDaten
		{    
			get 
			{	
				string daten;
				daten = this.KundenId + " " + this.Name;
				return daten;
			}
		}

        public void Insert()
        {
            DataTransfer dt = new DataTransfer();
            dt.InsertKunde(this);
        }
		

	}
		
}
