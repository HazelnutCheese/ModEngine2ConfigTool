﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModEngine2ConfigTool.Resx {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Help {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Help() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ModEngine2ConfigTool.Resx.Help", typeof(Help).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Saves downloaded from another player cannot be used with your own game. You need to use a tool to copy a saves character to your own save.
        ///
        ///I recommend using EldenRingSaveCopier:
        ///
        ///https://github.com/BenGrn/EldenRingSaveCopier
        ///
        ///If you want to use this along with a seperate save per profile I recommend starting your game first with the option enabled, creating a character and then exiting the game. You can then use the &quot;Go to Saves&quot; option to find that profiles save..
        /// </summary>
        internal static string Faq_CorruptDownloadedSave {
            get {
                return ResourceManager.GetString("Faq_CorruptDownloadedSave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis Mod Launcher does not currently support monitoring whether mods conflict.
        ///
        ///This is a feature I&apos;m hoping to add in a future release..
        /// </summary>
        internal static string Faq_HowCanITellIfModsConflict {
            get {
                return ResourceManager.GetString("Faq_HowCanITellIfModsConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis Mod Launcher does not supoort downloading mods. 
        ///
        ///Any mods must be downloaded from mod hosting websites and imported into Metis via the &quot;Add Mod from Folder&quot; or &quot;Add from Package&quot; buttons..
        /// </summary>
        internal static string Faq_HowToDownloadMods {
            get {
                return ResourceManager.GetString("Faq_HowToDownloadMods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click the &quot;Add Dll from File&quot; button on the side bar or on the External Dlls page.
        ///
        ///Select the dll file you want to import.
        ///
        ///Fill out any additional details such as name or description.
        ///
        ///Some external dlls files such as Seamless Coop come with additional files like a config file.  Follow the authors instructions on how to handle these files. For instance with Seamless Coop make sure the &quot;seamlesscoopsettings.ini&quot; remains next to the dll..
        /// </summary>
        internal static string Faq_HowToImportAnExternalDll {
            get {
                return ResourceManager.GetString("Faq_HowToImportAnExternalDll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click the &quot;Add Mod from Folder&quot; button on the side bar or on the Mods page. Or click the &quot;Add from Package&quot; option if you have a &quot;.metismodpkg&quot; file. 
        ///
        ///If you are using the first option a dialog will launch asking you to select the folder that contains the mods. This should include files such as &quot;Regulation.bin&quot;. 
        ///
        ///Fill out the details such as name and description.
        ///
        ///If you do not select the right folder then the game will launch without the mod active. If this happens double check the folder you have  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Faq_HowToImportMod {
            get {
                return ResourceManager.GetString("Faq_HowToImportMod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis Mod Launcher does not support merging mods.
        ///
        ///For now mods in a profile should be ordered in a way that causes the least conflicts.
        ///
        ///This is a feature that will be potentially looked at for a future version..
        /// </summary>
        internal static string Faq_HowToMergeMods {
            get {
                return ResourceManager.GetString("Faq_HowToMergeMods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please report any bugs or issues by raising a new issue on the github issues page:
        ///
        ///https://github.com/HazelnutCheese/ModEngine2ConfigTool/issues.
        /// </summary>
        internal static string Faq_IFoundABug {
            get {
                return ResourceManager.GetString("Faq_IFoundABug", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can import your vanilla saves or saves from another profile by clicking the import saves button (when &quot;Use profile specific save game&quot; is turned on) and selecting the folder containing the saves.
        ///
        ///Profile saves are stored under the profile Id which you can find in the Advanced Options box..
        /// </summary>
        internal static string Faq_ImportSaves {
            get {
                return ResourceManager.GetString("Faq_ImportSaves", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To make your profile use a seperate save edit the profile and expand the advanced options box.
        ///
        ///Inside here check the &quot;Use profile specific save game&quot; option.
        ///
        ///When you launch the game Metis will now backup your current saves and then give them temporary names. This will cause Elden Ring to generate a new save game for your profile. Metis will backup these saves and install / uninstall them each time you start Elden Ring via that profile.
        ///
        ///You can also manually backup your saves or import saves from a [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Faq_ProfileSaves {
            get {
                return ResourceManager.GetString("Faq_ProfileSaves", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If the Elden Ring starts up but then closes itself this may indicate an issue with the mods or dll you are using. They usually have to be updated to match the latest version of the game. Check to see if the last update to the mod was made before or after the latest Elden  Ring update was released and whether the author has said it is compatible. You may need to check a mods discord (if it has one) or nexus mods page to find this information.
        ///
        ///Log files are stored in &quot;%LOCALAPPDATA%\\Metis Mod Launcher\\Te [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Faq_TheGameCrashesOrDoesntWork {
            get {
                return ResourceManager.GetString("Faq_TheGameCrashesOrDoesntWork", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Export Package option on a mod page allows you to export your mod with it&apos;s name, description, image and files all as a single &quot;.metismodpkg&quot;. 
        ///
        ///When someone imports the package file via the &quot;Add from Package&quot; option the files will automatically be extracted to &quot;%LocalAppData%\Metis Mod Launcher\Imported\Mods&quot; under it&apos;s new profile id and the mod folder path will be updated accordingly. 
        ///
        ///This feature is designed to help distribute and install mods with less chance of user issues. 
        ///Currently this  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Faq_WhatDoesExportPackageDo {
            get {
                return ResourceManager.GetString("Faq_WhatDoesExportPackageDo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When you import a mod or external dll Metis stores a reference to it in an internal database. 
        ///
        ///This is just a record of where the file or folder is located and any additional options you might enable.
        ///
        ///This allows Metis to keep a record of any mods or external dlls you have and lets you combine them into multiple different profiles..
        /// </summary>
        internal static string Faq_WhatDoesImportingDo {
            get {
                return ResourceManager.GetString("Faq_WhatDoesImportingDo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis does not find mod folders or dlls that have been moved on disk after being added.
        ///
        ///If you have already added a mod or external dll and decide to move it after then you must edit the mod or external dll in Metis and use the &quot;Browse&quot; button to select the new location.
        ///
        ///If you do not update the items location after moving them then Metis will not be able to configure ModEngine2 to launch correctly..
        /// </summary>
        internal static string Faq_WhatHappensIfIMoveAModOrDllAfterImport {
            get {
                return ResourceManager.GetString("Faq_WhatHappensIfIMoveAModOrDllAfterImport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to External Dlls are library files that ModEngine2 can inject into games to add additional functionality.
        ///
        ///An example of an External Dll is Seamless Coop which adds functionality such as alternative coop functionality and a new save file format..
        /// </summary>
        internal static string Faq_WhatIsAnExternalDll {
            get {
                return ResourceManager.GetString("Faq_WhatIsAnExternalDll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis Mod Launcher is a tool designed to make using mods in Elden Ring via ModEngine2 a smoother experience.
        ///
        ///ModEngine2 is a modding engine built by garyttierney, katalash and Dasaav-dsv which hooks into games and allows the replacement of files and injecting of dlls.
        ///
        ///Metis Mod Launcher provides a user interface that allows collections of mods and dlls to be imported and saved in profiles with per profile save games. This allows players and mod developers to quickly swap between different mod configur [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Faq_WhatIsMetisModLauncher {
            get {
                return ResourceManager.GetString("Faq_WhatIsMetisModLauncher", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis will automatically keep backups of your profiles last 5 saves if you have profile specific saves enabled. These backups are created at launch and pruned at launch and are seperate to the Backup Saves button.
        ///
        ///You can find these saves in &quot;%LocalAppData%\Metis Mod Launcher\Saves\Backups&quot;. The saves are stored under your profiles Id (see Advanced Options in your profile) and you can import them back into your profile using the Import Saves button..
        /// </summary>
        internal static string Faq_WhereAreSavedBackedUp {
            get {
                return ResourceManager.GetString("Faq_WhereAreSavedBackedUp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Metis Mod Launcher stores it&apos;s application data in &quot;%LocalAppData%\Metis Mod Launcher&quot;.
        ///
        ///This includes the applications sqllite database, saves, save backups and temporary files..
        /// </summary>
        internal static string Faq_WhereDoesMetisStoreData {
            get {
                return ResourceManager.GetString("Faq_WhereDoesMetisStoreData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SeamlessCoop comes with a seamlesscoopsettings.ini file which contains a &quot;cooppassword&quot; field. 
        ///
        ///You must edit this file adding your password e.g. &quot;cooppassword = myNewPassword&quot; and then make sure the file is in the same folder as the &quot;elden_ring_seamless_coop.dll&quot;.
        ///
        ///Metis does not support using a different seamless coop settings file for each profile so all profiles will use the same password..
        /// </summary>
        internal static string FaqCoopPassword {
            get {
                return ResourceManager.GetString("FaqCoopPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MIT License (MIT)
        ///
        ///Copyright © 2014 Autofac Project
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy
        ///of this software and associated documentation files (the &quot;Software&quot;), to deal
        ///in the Software without restriction, including without limitation the rights
        ///to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        ///copies of the Software, and to permit persons to whom the Software is
        ///furnished to do so, subject to the following conditions:
        ///
        ///The above  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_Autofac {
            get {
                return ResourceManager.GetString("Licence_Autofac", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apache License
        ///                           Version 2.0, January 2004
        ///                        http://www.apache.org/licenses/
        ///
        ///   TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION
        ///
        ///   1. Definitions.
        ///
        ///      &quot;License&quot; shall mean the terms and conditions for use, reproduction,
        ///      and distribution as defined by Sections 1 through 9 of this document.
        ///
        ///      &quot;Licensor&quot; shall mean the copyright owner or entity authorized by
        ///      the copyright owner that is granting the License.
        ///
        ///      &quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_CalcBinding {
            get {
                return ResourceManager.GetString("Licence_CalcBinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MIT License
        ///
        ///Copyright (c) 2016 Ivan Gavryliuk
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy
        ///of this software and associated documentation files (the &quot;Software&quot;), to deal
        ///in the Software without restriction, including without limitation the rights
        ///to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        ///copies of the Software, and to permit persons to whom the Software is
        ///furnished to do so, subject to the following conditions:
        ///
        ///The above copyright [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_ConfigDotNet {
            get {
                return ResourceManager.GetString("Licence_ConfigDotNet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MICROSOFT SOFTWARE LICENSE TERMS
        ///
        ///MICROSOFT .NET LIBRARY
        ///
        ///These license terms are an agreement between you and Microsoft Corporation (or based on where you live, one of its affiliates). They apply to the software named above. The terms also apply to any Microsoft services or updates for the software, except to the extent those have different terms.
        ///
        ///IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW.
        ///
        ///1.    INSTALLATION AND USE RIGHTS.
        ///You may install and use any number of copies of  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_DotNetEf {
            get {
                return ResourceManager.GetString("Licence_DotNetEf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MIT License
        ///
        ///Copyright (c) 2020 Evaristo Cuesta
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy
        ///of this software and associated documentation files (the &quot;Software&quot;), to deal
        ///in the Software without restriction, including without limitation the rights
        ///to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        ///copies of the Software, and to permit persons to whom the Software is
        ///furnished to do so, subject to the following conditions:
        ///
        ///The above copyrigh [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_FolderBrowserEx {
            get {
                return ResourceManager.GetString("Licence_FolderBrowserEx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MIT License (MIT)
        ///
        ///Copyright (c) James Willock,  Mulholland Software and Contributors
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy
        ///of this software and associated documentation files (the &quot;Software&quot;), to deal
        ///in the Software without restriction, including without limitation the rights
        ///to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        ///copies of the Software, and to permit persons to whom the Software is
        ///furnished to do so, subject to the f [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_MaterialDesignInXamlToolkit {
            get {
                return ResourceManager.GetString("Licence_MaterialDesignInXamlToolkit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MIT License
        ///
        ///Copyright (c) 2023
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the &quot;Software&quot;), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        ///
        ///The above copyright notice and this [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_Metis {
            get {
                return ResourceManager.GetString("Licence_Metis", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permission is hereby granted, free of charge, to any
        ///person obtaining a copy of this software and associated
        ///documentation files (the &quot;Software&quot;), to deal in the
        ///Software without restriction, including without
        ///limitation the rights to use, copy, modify, merge,
        ///publish, distribute, sublicense, and/or sell copies of
        ///the Software, and to permit persons to whom the Software
        ///is furnished to do so, subject to the following
        ///conditions:
        ///
        ///The above copyright notice and this permission notice
        ///shall be incl [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_ModEngine2 {
            get {
                return ResourceManager.GetString("Licence_ModEngine2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MIT
        ///
        ///License text
        /// MIT License _____
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy of _____ (the &quot;Software&quot;), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        ///
        ///The above copyright notice and this permission notice (including the next pa [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_PowerArgs {
            get {
                return ResourceManager.GetString("Licence_PowerArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MIT License
        ///
        ///Copyright (c) 2022 Simon Schmid
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the &quot;Software&quot;), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
        ///
        ///The above copyright no [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_Sherlog {
            get {
                return ResourceManager.GetString("Licence_Sherlog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MIT License
        ///
        ///Copyright (c) 2020 Denis Zhidkikh
        ///
        ///Permission is hereby granted, free of charge, to any person obtaining a copy
        ///of this software and associated documentation files (the &quot;Software&quot;), to deal
        ///in the Software without restriction, including without limitation the rights
        ///to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
        ///copies of the Software, and to permit persons to whom the Software is
        ///furnished to do so, subject to the following conditions:
        ///
        ///The above copyright [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_Tommy {
            get {
                return ResourceManager.GetString("Licence_Tommy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Community Toolkit
        ///Copyright © .NET Foundation and Contributors
        ///
        ///All rights reserved.
        ///
        ///MIT License (MIT)
        ///Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_WindowsCommunityToolkit {
            get {
                return ResourceManager.GetString("Licence_WindowsCommunityToolkit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Reciprocal License (MS-RL)
        ///This license governs use of the accompanying software. If you use the software, you accept this license. If you do not accept the license, do not use the software.
        ///
        ///Definitions
        ///
        ///The terms &quot;reproduce,&quot; &quot;reproduction,&quot; &quot;derivative works,&quot; and &quot;distribution&quot; have the same meaning here as under U.S. copyright law.
        ///
        ///A &quot;contribution&quot; is the original software, or any additions or changes to the software.
        ///
        ///A &quot;contributor&quot; is any person that distributes its contribution  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Licence_Wix {
            get {
                return ResourceManager.GetString("Licence_Wix", resourceCulture);
            }
        }
    }
}
