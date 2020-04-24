using System;
using System.IO;
using System.Xml;
using System.Collections;
using Server.Mobiles;
using Server.Targeting;
using Server.Items;
using Server.Accounting;
using Server.Commands;

namespace Server.Mobiles
{
	public class PossessCommand
	{
		public static string FileName = "Possessed.xml";
		public static AccessLevel accessLevel = AccessLevel.GameMaster;

		public static ArrayList MobileList = new ArrayList();
		public static ArrayList SourceList = new ArrayList();
		public static ArrayList TargetList = new ArrayList();

		public static void Initialize()
		{
			CommandSystem.Register( "Possess", accessLevel, new CommandEventHandler( Possess_OnCommand ) );
            CommandSystem.Register("Unpossess", accessLevel, new CommandEventHandler(Unpossess_OnCommand));

			LoadFile();

			EventSink.WorldSave += new WorldSaveEventHandler( EventSink_WorldSave );
		}

		[Usage( "Possess" )]
		[Description( "Target a mobile to possess." )]
		private static void Possess_OnCommand( CommandEventArgs e )
		{
			Mobile mobile = (Mobile) e.Mobile;

			bool noStatMod = e.GetString( 0 ).ToLower() == "nostatmod";

			mobile.SendMessage( "Target a mobile you wish to possess." );
			mobile.Target = new InternalTarget( noStatMod );
		}

		private class InternalTarget : Target
		{
			private bool noStatMod;

			public InternalTarget( bool nostatmod ) : base( -1, true, TargetFlags.None )
			{
				noStatMod = nostatmod;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( targeted is BaseCreature )
				{
					BaseCreature target = (BaseCreature) targeted;

					MobileList.Add( from );

					ArrayList sourceList = new ArrayList();
					ArrayList sourcePropList = new ArrayList();
					ArrayList targetPropList = new ArrayList();
					ArrayList targetItemList = new ArrayList();
					ArrayList targetItemAmountList = new ArrayList();
					ArrayList targetList = new ArrayList();

					sourcePropList.Add( from.Name );
					sourcePropList.Add( from.Title == null ? "" : from.Title );
					sourcePropList.Add( from.BodyValue );
					sourcePropList.Add( from.BaseSoundID );
					sourcePropList.Add( from.Hue );
					sourcePropList.Add( from.Str );
					sourcePropList.Add( from.Dex );	
					sourcePropList.Add( from.Int );
					sourcePropList.Add( from.Hits );
					sourcePropList.Add( from.Stam );
					sourcePropList.Add( from.Mana );

					targetPropList.Add( target.GetType() );
					targetPropList.Add( target.Name );
					targetPropList.Add( target.Title == null ? "" : target.Title );
					targetPropList.Add( target.BodyValue );
					targetPropList.Add( target.BaseSoundID );
					targetPropList.Add( target.Hue );
					targetPropList.Add( target.Str );
					targetPropList.Add( target.Dex );	
					targetPropList.Add( target.Int );
					targetPropList.Add( target.HitsMax );
					targetPropList.Add( target.Hits );
					targetPropList.Add( target.Stam );
					targetPropList.Add( target.Mana );
					targetPropList.Add( target.Home );
					targetPropList.Add( target.RangeHome );

					if ( target.Backpack != null )
					{
						foreach ( Item item in target.Backpack.Items )
						{
							targetItemList.Add( item.GetType() );
							targetItemAmountList.Add( item.Amount );
						}
					}

					sourceList.Add( sourcePropList );
					targetList.Add( targetPropList );
					targetList.Add( targetItemList );
					targetList.Add( targetItemAmountList );
					SourceList.Add( sourceList );
					TargetList.Add( targetList );

					from.Hidden = false;
					from.Name = target.Name;
					from.Title = target.Title;
					from.BodyValue = target.BodyValue;
					from.BaseSoundID = target.BaseSoundID;
					from.Hue = target.Hue;

					if ( !noStatMod )
					{
						from.Str = target.Str;
						from.Dex = target.Dex;
						from.Int = target.Int;
						from.Hits = from.HitsMax;
						from.Stam = from.StamMax;
						from.Mana = from.ManaMax;
					}

					from.Location = target.Location;

					from.SendMessage( "You have possessed {0} ({1}).", target.Name, target.GetType().Name );

					target.Delete();
				}
				else
					from.SendMessage( "You cannot possess that!" );
			}
		}

		[Usage( "Unpossess" )]
		[Description( "Unpossess yourself from a possession." )]
		private static void Unpossess_OnCommand( CommandEventArgs e )
		{
			Mobile from = (Mobile) e.Mobile;

			bool returnStats = e.GetString( 0 ).ToLower() == "nodamage";

			Unpossess( from, returnStats );
		}

		public static void Unpossess( Mobile from, bool returnStats )
		{
			bool possessed = false;

			for ( int i = 0; i < MobileList.Count; i++ )
			{
				Mobile source = (Mobile) MobileList[i];

				if ( source == from )
				{
					possessed = true;

					Unpossess( from, i, false, returnStats );
				}
			}

			if ( !possessed )
				from.SendMessage( "You are not currently possessing a mobile!" );
		}

		public static bool UnpossessDeath( Mobile from )
		{
			if ( from.AccessLevel < accessLevel )
				return true;

			bool possessed = false;

			for ( int i = 0; i < MobileList.Count; i++ )
			{
				Mobile source = (Mobile) MobileList[i];

				if ( source == from )
				{
					possessed = true;

					Unpossess( from, i, true, false );
				}
			}

			return !possessed;
		}

		public static void Unpossess( Mobile from, int index, bool died, bool returnStats )
		{
			ArrayList sourceList = (ArrayList) SourceList[index];
			ArrayList targetList = (ArrayList) TargetList[index];
			ArrayList sourcePropList = (ArrayList) sourceList[0];
			ArrayList targetPropList = (ArrayList) targetList[0];
			ArrayList targetItemList = (ArrayList) targetList[1];
			ArrayList targetItemAmountList = (ArrayList) targetList[2];

			int fromHits = from.Hits;
			int fromStam = from.Stam;
			int fromMana = from.Mana;
			int fromHitsMax = from.HitsMax;
			int fromStamMax = from.StamMax;
			int fromManaMax = from.ManaMax;

			from.Name = (string)				sourcePropList[0];
			from.Title = (string)				sourcePropList[1];
			from.BodyValue = (int)				sourcePropList[2];
			from.BaseSoundID = (int)			sourcePropList[3];
			from.Hue = (int)				sourcePropList[4];
			from.Str = (int)				sourcePropList[5];
			from.Dex = (int)				sourcePropList[6];
			from.Int = (int)				sourcePropList[7];
			from.Hits = (int)				sourcePropList[8];
			from.Stam = (int)				sourcePropList[9];
			from.Mana = (int)				sourcePropList[10];

			from.Hidden = true;

			BaseCreature creature = Spawn( (Type) targetPropList[0], from );

			if ( creature == null )
			{
				from.SendMessage( "An error occurred. The creature type was returned null. Aborting..." );

				return;
			}

			creature.Name = (string)			targetPropList[1];
			creature.Title = (string)			targetPropList[2];
			creature.BodyValue = (int)			targetPropList[3];
			creature.BaseSoundID = (int)			targetPropList[4];
			creature.Hue = (int)				targetPropList[5];
			creature.Str = (int)				targetPropList[6];
			creature.Dex = (int)				targetPropList[7];
			creature.Int = (int)				targetPropList[8];
			creature.SetHits( (int) targetPropList[9] );

			if ( returnStats )
			{
				creature.Hits = (int)			targetPropList[10];
				creature.Stam = (int)			targetPropList[11];
				creature.Mana = (int)			targetPropList[12];
			}
			else
			{
				double hitsCalc = 1 - ( (double) fromHits / (double) fromHitsMax );
				double stamCalc = 1 - ( (double) fromStam / (double) fromStamMax );
				double manaCalc = 1 - ( (double) fromMana / (double) fromManaMax );
				double hitsLost = creature.HitsMax * hitsCalc;
				double stamLost = creature.StamMax * stamCalc;
				double manaLost = creature.ManaMax * manaCalc;

				creature.Hits = creature.HitsMax - (int) hitsLost;
				creature.Stam = creature.StamMax - (int) stamLost;
				creature.Mana = creature.ManaMax - (int) manaLost;
			}

			creature.Home = (Point3D)			targetPropList[13];
			creature.RangeHome = (int)			targetPropList[14];

			if ( creature.Backpack != null )
			{
				for( int j = 0; j < creature.Backpack.Items.Count; j++ )
				{
					Item item = (Item) creature.Backpack.Items[j];
					item.Consume();

					j--;
				}

				for ( int j = 0; j < targetItemList.Count; j++ )
				{
					Item item = (Item) Activator.CreateInstance( (Type) targetItemList[j] );

					if ( item.Stackable )
						item.Amount = (int) targetItemAmountList[j];

					creature.PackItem( item );
				}
			}

			if ( died )
			{
				from.SendMessage( "You were killed as you were possessing {0} ({1}). You have been returned to your previous form.", creature.Name, creature.GetType().Name );

				from.Hidden = true;
				creature.Kill();
			}
			else
			{
				from.SendMessage( "You have unpossessed {0} ({1}).", creature.Name, creature.GetType().Name );
			}

			MobileList.RemoveAt( index );
			SourceList.RemoveAt( index );
			TargetList.RemoveAt( index );
		}

		public static BaseCreature Spawn( Type spawnType, Mobile from )
		{
			if ( spawnType != null )
			{
				try
				{
					object o = Activator.CreateInstance( spawnType );

					BaseCreature creature = (BaseCreature) o;

					creature.Map = from.Map;
					creature.Location = from.Location;

					return creature;
				}
				catch{}
			}

			return null;
		}

		private static void EventSink_WorldSave( WorldSaveEventArgs e )
		{
			using ( StreamWriter sw = new StreamWriter( Path.Combine( Core.BaseDirectory, FileName ) ) )
			{
				XmlTextWriter xml = new XmlTextWriter( sw );

				xml.Formatting = Formatting.Indented;
				xml.IndentChar = '\t';
				xml.Indentation = 1;
				xml.WriteStartDocument( true );

				xml.WriteStartElement( "Possessed" );
				xml.WriteAttributeString( "count", MobileList.Count.ToString() );

				for ( int i = 0; i < MobileList.Count; i++ )
				{
					Mobile mobile = (Mobile) MobileList[i];

					SaveMobile( xml, mobile, i );
				}

				xml.WriteEndElement();

				xml.Close();
			}
		}

		public static void SaveMobile( XmlTextWriter xml, Mobile mobile, int index )
		{
			ArrayList sourceList = (ArrayList) SourceList[index];
			ArrayList targetList = (ArrayList) TargetList[index];
			ArrayList sourcePropList = (ArrayList) sourceList[0];
			ArrayList targetPropList = (ArrayList) targetList[0];
			ArrayList targetItemList = (ArrayList) targetList[1];
			ArrayList targetItemAmountList = (ArrayList) targetList[2];

			xml.WriteStartElement( "PossessedMobile" );

			xml.WriteStartElement( "AccountName" );
			xml.WriteString( ( (Account) mobile.Account ).Username.ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Name" );
			xml.WriteString( ( (string) sourcePropList[0] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Title" );
			xml.WriteString( ( (string) sourcePropList[1] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "BodyValue" );
			xml.WriteString( ( (int) sourcePropList[2] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "BaseSoundID" );
			xml.WriteString( ( (int) sourcePropList[3] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Hue" );
			xml.WriteString( ( (int) sourcePropList[4] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Str" );
			xml.WriteString( ( (int) sourcePropList[5] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Dex" );
			xml.WriteString( ( (int) sourcePropList[6] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Int" );
			xml.WriteString( ( (int) sourcePropList[7] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Hits" );
			xml.WriteString( ( (int) sourcePropList[8] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Stam" );
			xml.WriteString( ( (int) sourcePropList[9] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "Mana" );
			xml.WriteString( ( (int) sourcePropList[10] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureType" );
			xml.WriteString( ( ( (Type) targetPropList[0] ).Name ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureName" );
			xml.WriteString( ( (string) targetPropList[1] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureTitle" );
			xml.WriteString( ( (string) targetPropList[2] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureBodyValue" );
			xml.WriteString( ( (int) targetPropList[3] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureBaseSoundID" );
			xml.WriteString( ( (int) targetPropList[4] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureHue" );
			xml.WriteString( ( (int) targetPropList[5] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureStr" );
			xml.WriteString( ( (int) targetPropList[6] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureDex" );
			xml.WriteString( ( (int) targetPropList[7] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureInt" );
			xml.WriteString( ( (int) targetPropList[8] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureHitsMax" );
			xml.WriteString( ( (int) targetPropList[9] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureHits" );
			xml.WriteString( ( (int) targetPropList[10] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureStam" );
			xml.WriteString( ( (int) targetPropList[11] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureMana" );
			xml.WriteString( ( (int) targetPropList[12] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureHome" );
			xml.WriteString( ( (Point3D) targetPropList[13] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureRangeHome" );
			xml.WriteString( ( (int) targetPropList[14] ).ToString() );
			xml.WriteEndElement();

			xml.WriteStartElement( "CreatureItemList" );
			xml.WriteAttributeString( "count", targetItemList.Count.ToString() );

			for ( int i = 0; i < targetItemList.Count; i++ )
			{
				xml.WriteStartElement( "ItemList" );

				xml.WriteStartElement( "Item" );
				xml.WriteString( ( ( (Type) targetItemList[i] ).Name ).ToString() );
				xml.WriteEndElement();

				xml.WriteStartElement( "ItemAmount" );
				xml.WriteString( ( (int) targetItemAmountList[i] ).ToString() );
				xml.WriteEndElement();

				xml.WriteEndElement();
			}

			xml.WriteEndElement();
		}

		public static string GetInnerText( XmlElement node )
		{
			if ( node == null )
				return "Error";

			return node.InnerText;
		}

		public static void LoadFile()
		{
			if ( !File.Exists( FileName ) )
				return;

			XmlDocument xml = new XmlDocument();
			xml.Load( FileName );

			XmlElement possessed = xml["Possessed"];

			foreach ( XmlElement mobile in possessed.GetElementsByTagName( "PossessedMobile" ) )
				LoadMobile( mobile, FileName );
		}

		public static void LoadMobile( XmlElement mobile, string FileName )
		{
			ArrayList sourceList = new ArrayList();
			ArrayList sourcePropList = new ArrayList();
			ArrayList targetPropList = new ArrayList();
			ArrayList targetItemList = new ArrayList();
			ArrayList targetItemAmountList = new ArrayList();
			ArrayList targetList = new ArrayList();

			string accountName = null;

			try{ accountName = GetInnerText( mobile["AccountName"] ); }
			catch{}

			try{ sourcePropList.Add( GetInnerText( mobile["Name"] ) ); }
			catch{}

			try{ sourcePropList.Add( GetInnerText( mobile["Title"] ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["BodyValue"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["BaseSoundID"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Hue"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Str"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Dex"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Int"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Hits"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Stam"] ) ) ); }
			catch{}

			try{ sourcePropList.Add( int.Parse( GetInnerText( mobile["Mana"] ) ) ); }
			catch{}

			try{ targetPropList.Add( ScriptCompiler.FindTypeByName( GetInnerText( mobile["CreatureType"] ) ) ); }
			catch{}

			string creatureName = null;

			try{ creatureName = GetInnerText( mobile["CreatureName"] ); }
			catch{}

			SetMobile( accountName.ToLower(), creatureName.ToLower() );

			targetPropList.Add( creatureName );

			try{ targetPropList.Add( GetInnerText( mobile["CreatureTitle"] ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureBodyValue"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureBaseSoundID"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureHue"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureStr"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureDex"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureInt"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureHitsMax"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureHits"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureStam"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureMana"] ) ) ); }
			catch{}

			try{ targetPropList.Add( Point3D.Parse( GetInnerText( mobile["CreatureHome"] ) ) ); }
			catch{}

			try{ targetPropList.Add( int.Parse( GetInnerText( mobile["CreatureRangeHome"] ) ) ); }
			catch{}

			XmlElement creatureItemList = null;

			try{ creatureItemList = mobile["CreatureItemList"]; }
			catch{}

			foreach ( XmlElement item in creatureItemList.GetElementsByTagName( "ItemList" ) )
			{
				try{ targetItemList.Add( ScriptCompiler.FindTypeByName( GetInnerText( item["Item"] ) ) ); }
				catch{}

				try{ targetItemAmountList.Add( int.Parse( GetInnerText( item["ItemAmount"] ) ) ); }
				catch{}
			}

			sourceList.Add( sourcePropList );
			targetList.Add( targetPropList );
			targetList.Add( targetItemList );
			targetList.Add( targetItemAmountList );
			SourceList.Add( sourceList );
			TargetList.Add( targetList );
		}

		public static void SetMobile( string accountName, string name )
		{
			foreach ( Mobile mobile in World.Mobiles.Values )
			{
				if ( mobile.Player )
				{
					string account = ( (Account) mobile.Account ).Username.ToString().ToLower();

					if ( account == accountName && mobile.Name.ToLower() == name )
					{
						MobileList.Add( mobile );

						break;
					}
				}
			}
		}
	}
}