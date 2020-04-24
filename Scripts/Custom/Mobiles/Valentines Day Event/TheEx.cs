using System;
using Server.Items;

namespace Server.Mobiles

              {
              [CorpseName( " Corpse of The Ex" )]
              public class TheEx : BaseCreature
              {
                                 [Constructable]
                  public TheEx()
                      : base(AIType.AI_Melee, FightMode.Closest, 14, 1, 0.8, 1.6)
                            {
                                        SpeechHue = Utility.RandomDyedHue();
                                        
                                        
                                              
                                               Name = "The Ex";
                                               Hue = 1010;
                                               Body = 0x190;

                                               PlateChest pChest = new PlateChest();
                                               pChest.Hue = 1899; 
                                               AddItem(pChest);
                                               PlateArms pArms = new PlateArms();
                                               pArms.Hue = 1899; 
                                               AddItem(pArms);
                                               PlateGloves pGloves = new PlateGloves();
                                               pGloves.Hue = 1899; 
                                               AddItem(pGloves);
                                               PlateGorget pGorget = new PlateGorget();
                                               pGorget.Hue = 1899;
                                               AddItem(pGorget);
                                               PlateLegs pLegs = new PlateLegs();
                                               pLegs.Hue = 1899;
                                               AddItem(pLegs);
                                               PlateHelm pHelm = new PlateHelm();
                                               pHelm.Hue = 1899; 
                                               AddItem(pHelm);
                                               AddItem(new Boots(1899));
                                               
                                               SetStr( 340 );
                                               SetDex( 500 );
                                               SetInt( 80 );
                                               SetHits( 35000, 40000 );
                                               SetDamage( 30, 40 );

                                               Skills[SkillName.Anatomy].Base = 120.0;
                                               Skills[SkillName.Tactics].Base = 120.0;
                                               Skills[SkillName.Swords].Base = 120.0;
                                               Skills[SkillName.MagicResist].Base = 120.0;
                                               Skills[SkillName.DetectHidden].Base = 100.0;
                                               
                                               Fame = 50000;
                                               Karma = -50000;
											   
											   PackItem( new WhiteFang(40) );

                                               Utility.AssignRandomHair(this);
                                               if (Utility.RandomBool())
                                                   Utility.AssignRandomFacialHair(this, HairHue);


                                               Cutlass c = new Cutlass();
                                               c.Hue = 1899;
                                               AddItem(c);
                                               
                                               

                                               HeaterShield h = new HeaterShield();
                                               h.Hue = 1899;
                                               AddItem(h);
                                               
                                                
                                     
                                                PackGold( 5000, 8700 );
                                                

                            }


public TheEx( Serial serial ) : base( serial )
                      {
                      }
public override bool AlwaysMurderer { get { return true; } }
public override void Serialize( GenericWriter writer )
                      {
                                        base.Serialize( writer );
                                        writer.Write( (int) 0 );
                      }

        public override void Deserialize( GenericReader reader )
                      {
                                        base.Deserialize( reader );
                                        int version = reader.ReadInt();
                      }
    }
}
