//
//  _   _         ______    _ _ _   _             _ _ _
// | \ | |       |  ____|  | (_) | (_)           | | | |
// |  \| | ___   | |__   __| |_| |_ _ _ __   __ _| | | |
// | . ` |/ _ \  |  __| / _` | | __| | '_ \ / _` | | | |
// | |\  | (_) | | |___| (_| | | |_| | | | | (_| |_|_|_|
// |_| \_|\___/  |______\__,_|_|\__|_|_| |_|\__, (_|_|_)
//                                           __/ |
//                                          |___/
// 
// This file is auto-generated. Do not edit manually
// 
// Copyright 2013 Automatak LLC
// 
// Automatak LLC (www.automatak.com) licenses this file
// to you under the the Apache License Version 2.0 (the "License"):
// 
// http://www.apache.org/licenses/LICENSE-2.0.html
//

namespace Automatak.DNP3.Interface
{
  /// <summary>
  /// Determines what the master station does when it sees the NEED_TIME iin bit
  /// </summary>
  public enum TimeSyncMode : byte
  {
    /// <summary>
    /// synchronize the outstation's time using the non-LAN time sync procedure
    /// </summary>
    NonLANTimeSync = 1,
    /// <summary>
    /// synchronize the outstation's time using the LAN time sync procedure
    /// </summary>
    LANTimeSync = 2,
    /// <summary>
    /// don't perform a time-sync
    /// </summary>
    None = 0
  }
}
