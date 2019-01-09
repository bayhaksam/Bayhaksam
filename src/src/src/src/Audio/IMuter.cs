//-----------------------------------------------------------------------
// <copyright file="IMuter.cs" company="Bayhaksam">
//      Copyright (c) Bayhaksam. All rights reserved.
// </copyright>
// <author>Samet Kurumahmut</author>
//-----------------------------------------------------------------------

namespace Bayhaksam.Audio
{
	/// <summary>
	/// Muter interface to mute/un-mute the sound.
	/// </summary>
	public interface IMuter
	{
		/// <summary>
		/// Mutes the sound.
		/// </summary>
		void Mute();

		/// <summary>
		/// Mutes the sound by specified <paramref name="value"/>.
		/// </summary>
		void Mute(bool value);

		/// <summary>
		/// Un-Mutes the sound.
		/// </summary>
		void UnMute();
	}
}
