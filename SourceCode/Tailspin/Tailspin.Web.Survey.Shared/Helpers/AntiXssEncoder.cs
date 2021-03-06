﻿//===============================================================================
// Microsoft patterns & practices
// Windows Azure Architecture Guide
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://wag.codeplex.com/license)
//===============================================================================


namespace Tailspin.Web.Survey.Shared.Helpers
{
    using System.IO;
    using System.Web.Util;
    using Microsoft.Security.Application;

    public class AntiXssEncoder : HttpEncoder
    {
        protected override void HtmlAttributeEncode(string value, TextWriter output)
        {
            output.Write(Encoder.HtmlAttributeEncode(value));
        }

        protected override void HtmlEncode(string value, TextWriter output)
        {
            output.Write(Encoder.HtmlEncode(value));
        }
    }
}