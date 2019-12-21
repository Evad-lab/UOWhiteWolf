/*
Created by BobClown to supplement David's talking statue script
*/

using System;
using Server.Misc;
using System.Collections;
using System.Collections.Generic;
using Server.ContextMenus;
using Server.Multis;

namespace Server.Items
{
	public class TalkingStatueBase : Item
	{
		public bool m_IsTalking = true;

		public TalkingStatueBase( int _ItemID ) : base( _ItemID )
		{
		}

		public bool IsTalking
		{
			get{ return m_IsTalking; }
			set{ m_IsTalking = value; }
		}

		public override bool HandlesOnMovement
		{
			get{ return m_IsTalking; }
		}

		public override void GetContextMenuEntries( Mobile from, List<ContextMenuEntry> list )
		{
			base.GetContextMenuEntries( from, list );

			if ( from != null && IsChildOf( from.Backpack ) )
				list.Add( new TurnOffOnEntry( this ) );
		}

		public TalkingStatueBase( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
		}
	}

	public class TurnOffOnEntry : ContextMenuEntry
	{
		private TalkingStatueBase m_Base;

		public TurnOffOnEntry( TalkingStatueBase _base ) : base( (_base.IsTalking ? 410 : 411), 2 )  // "Off" and "On"
		{
			m_Base = _base;
		}

		public override void OnClick()
		{
			m_Base.IsTalking = !m_Base.IsTalking;
		}
	}
}