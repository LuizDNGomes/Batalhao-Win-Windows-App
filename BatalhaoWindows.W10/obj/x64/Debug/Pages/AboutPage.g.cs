﻿#pragma checksum "C:\Users\Lenovo\OneDrive - Excel Engenharia\Documentos\GitHub\Batalhao-Win-Windows-App\BatalhaoWindows.W10\Pages\AboutPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF6B2DA97332B60BA5658B529DF54F85BA23CA5EB90A4BC8162E3EC0CC4123F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatalhaoWindows.Pages
{
    partial class AboutPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(global::Windows.UI.Xaml.Controls.HyperlinkButton obj, global::System.Uri value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), targetNullValue);
                }
                obj.NavigateUri = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
            public static void Set_Windows_UI_Xaml_Documents_Run_Text(global::Windows.UI.Xaml.Documents.Run obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class AboutPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IAboutPage_Bindings
        {
            private global::BatalhaoWindows.Pages.AboutPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj4;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj5;
            private global::Windows.UI.Xaml.Controls.StackPanel obj6;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj7;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj8;
            private global::Windows.UI.Xaml.Controls.HyperlinkButton obj9;
            private global::Windows.UI.Xaml.Documents.Run obj10;
            private global::Windows.UI.Xaml.Controls.Image obj11;
            private global::Windows.UI.Xaml.Documents.Run obj12;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TextDisabled = false;
            private static bool isobj3TextDisabled = false;
            private static bool isobj4NavigateUriDisabled = false;
            private static bool isobj5VisibilityDisabled = false;
            private static bool isobj5CommandDisabled = false;
            private static bool isobj6VisibilityDisabled = false;
            private static bool isobj7NavigateUriDisabled = false;
            private static bool isobj8NavigateUriDisabled = false;
            private static bool isobj9NavigateUriDisabled = false;
            private static bool isobj10TextDisabled = false;
            private static bool isobj11SourceDisabled = false;
            private static bool isobj12TextDisabled = false;

            private AboutPage_obj1_BindingsTracking bindingsTracking;

            public AboutPage_obj1_Bindings()
            {
                this.bindingsTracking = new AboutPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 14 && columnNumber == 21)
                {
                    isobj2TextDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 21)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 50 && columnNumber == 21)
                {
                    isobj4NavigateUriDisabled = true;
                }
                else if (lineNumber == 55 && columnNumber == 25)
                {
                    isobj5VisibilityDisabled = true;
                }
                else if (lineNumber == 56 && columnNumber == 25)
                {
                    isobj5CommandDisabled = true;
                }
                else if (lineNumber == 58 && columnNumber == 21)
                {
                    isobj6VisibilityDisabled = true;
                }
                else if (lineNumber == 66 && columnNumber == 7)
                {
                    isobj7NavigateUriDisabled = true;
                }
                else if (lineNumber == 70 && columnNumber == 7)
                {
                    isobj8NavigateUriDisabled = true;
                }
                else if (lineNumber == 91 && columnNumber == 8)
                {
                    isobj9NavigateUriDisabled = true;
                }
                else if (lineNumber == 42 && columnNumber == 26)
                {
                    isobj10TextDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 32)
                {
                    isobj11SourceDisabled = true;
                }
                else if (lineNumber == 21 && columnNumber == 26)
                {
                    isobj12TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Pages\AboutPage.xaml line 13
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 3: // Pages\AboutPage.xaml line 44
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // Pages\AboutPage.xaml line 48
                        this.obj4 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 5: // Pages\AboutPage.xaml line 52
                        this.obj5 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 6: // Pages\AboutPage.xaml line 57
                        this.obj6 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 7: // Pages\AboutPage.xaml line 64
                        this.obj7 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 8: // Pages\AboutPage.xaml line 68
                        this.obj8 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 9: // Pages\AboutPage.xaml line 87
                        this.obj9 = (global::Windows.UI.Xaml.Controls.HyperlinkButton)target;
                        break;
                    case 10: // Pages\AboutPage.xaml line 42
                        this.obj10 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    case 11: // Pages\AboutPage.xaml line 35
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 12: // Pages\AboutPage.xaml line 21
                        this.obj12 = (global::Windows.UI.Xaml.Documents.Run)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IAboutPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::BatalhaoWindows.Pages.AboutPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BatalhaoWindows.Pages.AboutPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel(obj.AboutThisAppModel, phase);
                    }
                }
            }
            private void Update_AboutThisAppModel(global::BatalhaoWindows.ViewModels.AboutThisAppViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AboutThisAppModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel_AppName(obj.AppName, phase);
                        this.Update_AboutThisAppModel_AboutText(obj.AboutText, phase);
                        this.Update_AboutThisAppModel_Privacy(obj.Privacy, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel_IsMoreInfoVisible(obj.IsMoreInfoVisible, phase);
                        this.Update_AboutThisAppModel_ViewMoreInfoCommand(obj.ViewMoreInfoCommand, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AboutThisAppModel_WasLibs(obj.WasLibs, phase);
                        this.Update_AboutThisAppModel_NewtonsoftWeb(obj.NewtonsoftWeb, phase);
                        this.Update_AboutThisAppModel_WindowsAppStudioWeb(obj.WindowsAppStudioWeb, phase);
                        this.Update_AboutThisAppModel_Publisher(obj.Publisher, phase);
                        this.Update_AboutThisAppModel_AppLogo(obj.AppLogo, phase);
                        this.Update_AboutThisAppModel_AppVersion(obj.AppVersion, phase);
                    }
                }
            }
            private void Update_AboutThisAppModel_AppName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 13
                    if (!isobj2TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj2, obj, null);
                    }
                }
            }
            private void Update_AboutThisAppModel_AboutText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 44
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_AboutThisAppModel_Privacy(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 48
                    if (!isobj4NavigateUriDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj4, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                    }
                }
            }
            private void Update_AboutThisAppModel_IsMoreInfoVisible(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Pages\AboutPage.xaml line 52
                    if (!isobj5VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), "true", null));
                    }
                    // Pages\AboutPage.xaml line 57
                    if (!isobj6VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BoolToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                    }
                }
            }
            private void Update_AboutThisAppModel_ViewMoreInfoCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Pages\AboutPage.xaml line 52
                    if (!isobj5CommandDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj5, obj, null);
                    }
                }
            }
            private void Update_AboutThisAppModel_WasLibs(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 64
                    if (!isobj7NavigateUriDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj7, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                    }
                }
            }
            private void Update_AboutThisAppModel_NewtonsoftWeb(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 68
                    if (!isobj8NavigateUriDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj8, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                    }
                }
            }
            private void Update_AboutThisAppModel_WindowsAppStudioWeb(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 87
                    if (!isobj9NavigateUriDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_HyperlinkButton_NavigateUri(this.obj9, (global::System.Uri) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Uri), obj), null);
                    }
                }
            }
            private void Update_AboutThisAppModel_Publisher(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 42
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj10, obj, null);
                    }
                }
            }
            private void Update_AboutThisAppModel_AppLogo(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 35
                    if (!isobj11SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj11, obj, null);
                    }
                }
            }
            private void Update_AboutThisAppModel_AppVersion(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\AboutPage.xaml line 21
                    if (!isobj12TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Documents_Run_Text(this.obj12, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class AboutPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<AboutPage_obj1_Bindings> weakRefToBindingObj; 

                public AboutPage_obj1_BindingsTracking(AboutPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<AboutPage_obj1_Bindings>(obj);
                }

                public AboutPage_obj1_Bindings TryGetBindingObject()
                {
                    AboutPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_AboutThisAppModel(null);
                }

                public void PropertyChanged_AboutThisAppModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    AboutPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::BatalhaoWindows.ViewModels.AboutThisAppViewModel obj = sender as global::BatalhaoWindows.ViewModels.AboutThisAppViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_AboutThisAppModel_IsMoreInfoVisible(obj.IsMoreInfoVisible, DATA_CHANGED);
                                bindings.Update_AboutThisAppModel_ViewMoreInfoCommand(obj.ViewMoreInfoCommand, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsMoreInfoVisible":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AboutThisAppModel_IsMoreInfoVisible(obj.IsMoreInfoVisible, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "ViewMoreInfoCommand":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_AboutThisAppModel_ViewMoreInfoCommand(obj.ViewMoreInfoCommand, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::BatalhaoWindows.ViewModels.AboutThisAppViewModel cache_AboutThisAppModel = null;
                public void UpdateChildListeners_AboutThisAppModel(global::BatalhaoWindows.ViewModels.AboutThisAppViewModel obj)
                {
                    if (obj != cache_AboutThisAppModel)
                    {
                        if (cache_AboutThisAppModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AboutThisAppModel).PropertyChanged -= PropertyChanged_AboutThisAppModel;
                            cache_AboutThisAppModel = null;
                        }
                        if (obj != null)
                        {
                            cache_AboutThisAppModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AboutThisAppModel;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Pages\AboutPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    AboutPage_obj1_Bindings bindings = new AboutPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
