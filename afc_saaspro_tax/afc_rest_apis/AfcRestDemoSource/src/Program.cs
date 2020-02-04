/**************************************************************************
 **                                                                       *
 ** Copyright 2017 by Avalara, Inc.                                       *
 **   All Rights Reserved. No part of this publication may be reproduced, *
 **   stored in a retrieval system, or transmitted, in any form, by any   *
 **   means, without the prior written permission of the publisher.       *
 **                                                                       *
 **************************************************************************
*/

using System;
using System.Windows.Forms;

namespace Avalara.CommsPlatform.Api.RestDemoApplication
{
    /// <summary>
    /// Avalara for Communications REST Demo Application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Main entry point for application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AfcRestDemoForm());
        }
    }
}
