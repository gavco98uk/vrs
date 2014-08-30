﻿// Copyright © 2014 onwards, Andrew Whewell
// All rights reserved.
//
// Redistribution and use of this software in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//    * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//    * Neither the name of the author nor the names of the program's contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE AUTHORS OF THE SOFTWARE BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualRadar.Interface.Network
{
    /// <summary>
    /// An active connector that connects to a machine over the IP network.
    /// </summary>
    public interface IIPActiveConnector : IActiveConnector
    {
        /// <summary>
        /// Gets the address of the machine to connect to.
        /// </summary>
        string Address { get; }

        /// <summary>
        /// Gets the port to connect to.
        /// </summary>
        int Port { get; }

        /// <summary>
        /// Gets a value indicating that keep-alive packets are to be used instead of the
        /// connection reset value.
        /// </summary>
        /// <remarks>
        /// Note that Mono does not support the use of keep-alive packets. When running under
        /// Mono this flag is always set to false.
        /// </remarks>
        bool UseKeepAlive { get; }

        /// <summary>
        /// Gets the period of inactivity (in milliseconds) before the connection is reset.
        /// </summary>
        int ResetConnectionTimeout { get; }

        /// <summary>
        /// Sets the <see cref="Address"/> and <see cref="Port"/>.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        /// <param name="useKeepAlive"></param>
        /// <param name="resetConnectionTimeout"></param>
        /// <remarks>
        /// Note that Mono does not support the use of keep-alive packets. Under Mono the
        /// <paramref name="useKeepAlive"/> parameter is ignored.
        /// </remarks>
        void SetConnectionProperties(string address, int port, bool useKeepAlive, int resetConnectionTimeout);
    }
}