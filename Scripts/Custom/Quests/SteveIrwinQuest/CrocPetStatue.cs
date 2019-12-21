using System;
using Server.Items;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
   public class CrocodillPetStatue : Item
   {
      [Constructable]
      public CrocodillPetStatue() : base( 8497 )
      {
         Movable = true;
         Name = "A Pet Croc Statue";
         LootType=LootType.Blessed;
      }

      public override void OnDoubleClick( Mobile from )
      {

	PlayerMobile pm = from as PlayerMobile;

			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else if( from.InRange( this.GetWorldLocation(), 1 ) ) 
		        {
           		from.FixedParticles( 0x373A, 10, 15, 5036, EffectLayer.Head ); 
               		from.PlaySound( 521 );
        		Crocodill crocodill = new Crocodill();
        		crocodill.Controlled = true;
        		crocodill.ControlMaster = from;
        		crocodill.IsBonded = true;
        		crocodill.Location = from.Location;
        		crocodill.Map = from.Map;
        		World.AddMobile( crocodill );
               		from.SendMessage( "You Summon Your Pet Croc." );
      			this.Delete();
		        } 
		        else 
		        { 
		            from.SendLocalizedMessage( 500446 ); // That is too far away. 
		        }
      }

      public CrocodillPetStatue( Serial serial ) : base( serial )
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

         int version = reader.ReadInt();
      }
   }
}
