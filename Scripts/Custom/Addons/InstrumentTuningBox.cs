//  InstrumentTuningBox.cs                                                             //
//  by Beelzebubba                                                                     //
//                                                                                     //
//  Version 1.0                                                                        //   
//                                                                                     //
//  Put this in your custom scripts folder. Add InstrumentTuningBox as an item in      //
//  loot scripts, etc. or use [add InstrumentTuningBox to add the item in the world.   //
//                                                                                     //
//  When someone double clicks the InstrumentTuningBox they will get a targeting       //
//  cursor and a message to click on the instrument they wish to tune. When they       //
//  then click on a Lute, Drums, Tambourine, or Tambourine with Tassels a song will    //
//  play and that instrument's song will be changed. This can be done repeatedly on    //
//  the same instrument, and the song will cycle between any of the 4 songs available  //
//  for that instrument. If an instrument other than those listed above, or another    //
//  item is clicked on, a message will appear stating that you can only change the     //
//  song on Lute, Drums, or Tambourines. Additionally the instrument cannot be locked  //
//  down when changing the song.                                                       //
//                                                                                     //
/////////////////////////////////////////////////////////////////////////////////////////

using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;

namespace Server.Items
{
    #region InstrumentTuningBoxTarget
    public class InstrumentTuningBoxTarget : Target
    {
        private InstrumentTuningBox m_Box;

		public InstrumentTuningBoxTarget( InstrumentTuningBox box ) : base( 1, false, TargetFlags.None )
		{
			m_Box = box;
		}

		protected override void OnTarget( Mobile from, object target )
        {
            #region Lute Songs
            if (target is Lute)
            {
                BaseInstrument item = (BaseInstrument)target;

                if (item.Movable == true)
                {
                    switch (item.SuccessSound)
                    {
                        case 0x4C:
                            item.SuccessSound = 0x403;
                            from.SendMessage("You have tuned your lute to play a new song.");
                            from.PlaySound(0x403);
                            break;
                        case 0x403:
                            item.SuccessSound = 0x418;
                            from.SendMessage("You have tuned your lute to play a new song.");
                            from.PlaySound(0x418);
                            break;
                        case 0x418:
                            item.SuccessSound = 0x40B;
                            from.SendMessage("You have tuned your lute to play a new song.");
                            from.PlaySound(0x40B);
                            break;
                        case 0x40B:
                            item.SuccessSound = 0x4C;
                            from.SendMessage("You have tuned your lute to play a new song.");
                            from.PlaySound(0x4C); // This is the normal UO Lute song.
                            break;

                        default:
                            item.SuccessSound = 0x4C;
                            from.SendMessage("You have tuned your lute.");
                            from.PlaySound(0x4C); // This is the normal UO Lute song.
                            break;
                    }
                }
                else
                {
                    from.SendMessage("You may not tune a lute that is locked down.");
                }

            }
            #endregion
            
            #region Drum Songs
            else if (target is Drums)
                {
                    BaseInstrument item = (BaseInstrument)target;

                    if (item.Movable == true)
                    {

                        switch (item.SuccessSound)
                        {
                            case 0x38:
                                item.SuccessSound = 0x2EA;
                                from.SendMessage("You have tuned your drum to play a new song.");
                                from.PlaySound(0x2EA);
                                break;
                            case 0x2EA:
                                item.SuccessSound = 0x2EC;
                                from.SendMessage("You have tuned your drum to play a new song.");
                                from.PlaySound(0x2EC);
                                break;
                            case 0x2EC:
                                item.SuccessSound = 0x2ED;
                                from.SendMessage("You have tuned your drum to play a new song.");
                                from.PlaySound(0x2ED);
                                break;
                            case 0x2ED:
                                item.SuccessSound = 0x38;
                                from.SendMessage("You have tuned your drum to play a new song.");
                                from.PlaySound(0x38); // This is the normal UO Drums song.
                                break;

                            default:
                                item.SuccessSound = 0x38;
                                from.SendMessage("You have tuned your drum.");
                                from.PlaySound(0x38); // This is the normal UO Drums song.
                                break;
                        }
                    }
                    else
                    {
                        from.SendMessage("You may not tune drums that are locked down.");
                    }
                }
            #endregion

            #region Tambourine Songs
                else if (target is Tambourine)
                {
                    BaseInstrument item = (BaseInstrument)target;

                    if (item.Movable == true)
                    {

                        switch (item.SuccessSound)
                        {
                            case 0x52:
                                item.SuccessSound = 0x4B5;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x4B5);
                                break;
                            case 0x4B5:
                                item.SuccessSound = 0x4B6;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x4B6);
                                break;
                            case 0x4B6:
                                item.SuccessSound = 0x4B7;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x4B7);
                                break;
                            case 0x4B7:
                                item.SuccessSound = 0x52;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x52); // This is the normal UO Tambourine song.
                                break;

                            default:
                                item.SuccessSound = 0x52;
                                from.SendMessage("You have tuned your tambourine.");
                                from.PlaySound(0x52); // This is the normal UO Tambourine song.
                                break;
                        }
                    }
                    else
                    {
                        from.SendMessage("You may not tune a tambourine that is locked down.");
                    }
                }
                #endregion

            #region Tambourine with Tassel Songs
                else if (target is TambourineTassel)
                {
                    BaseInstrument item = (BaseInstrument)target;

                    if (item.Movable == true)
                    {

                        switch (item.SuccessSound)
                        {
                            case 0x52:
                                item.SuccessSound = 0x4B5;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x4B5);
                                break;
                            case 0x4B5:
                                item.SuccessSound = 0x4B6;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x4B6);
                                break;
                            case 0x4B6:
                                item.SuccessSound = 0x4B7;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x4B7);
                                break;
                            case 0x4B7:
                                item.SuccessSound = 0x52;
                                from.SendMessage("You have tuned your tambourine to play a new song.");
                                from.PlaySound(0x52); // This is the normal UO Tambourine song.
                                break;

                            default:
                                item.SuccessSound = 0x52;
                                from.SendMessage("You have tuned your tambourine.");
                                from.PlaySound(0x52); // This is the normal UO Tambourine song.
                                break;
                        }
                    }
                    else
                    {
                        from.SendMessage("You may not tune a tambourine that is locked down.");
                    }  
                }

                else
                {
                    from.SendMessage("You may only tune drums, lutes, or tambourines.");
                }
                #endregion
        }
    }
    #endregion

    #region InstrumentTuningBox
        public class InstrumentTuningBox : Item
	{
		public override string DefaultName
		{
            get { return "a musical instrument tuning box"; }
		}

		[Constructable]
		public InstrumentTuningBox() : base( 0x2AF9 )
		{
			Weight = 10.0;
		}

		public InstrumentTuningBox( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			LootType = LootType.Blessed;

			int version = reader.ReadInt();
		}

		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from )
		{
            from.SendMessage("What instrument would you like to tune?");
			from.Target = new InstrumentTuningBoxTarget( this );
		}
    }
    #endregion
}