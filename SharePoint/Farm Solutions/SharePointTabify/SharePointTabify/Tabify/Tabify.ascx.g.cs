﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharePointTabify.Tabify {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class Tabify {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.ScriptLink ScriptLink1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.ScriptLink ScriptLink2;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.ScriptLink ScriptLink3;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.ScriptLink ScriptLink4;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(Tabify target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.ScriptLink @__BuildControlScriptLink1() {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.ScriptLink();
            this.ScriptLink1 = @__ctrl;
            @__ctrl.ID = "ScriptLink1";
            @__ctrl.Name = "/_layouts/15/SharePointTabify/js/jquery-3.1.1.min.js";
            @__ctrl.Localizable = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.ScriptLink @__BuildControlScriptLink2() {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.ScriptLink();
            this.ScriptLink2 = @__ctrl;
            @__ctrl.ID = "ScriptLink2";
            @__ctrl.Name = "/_layouts/15/SharePointTabify/js/jquery-ui-1.12.1.min.js";
            @__ctrl.Localizable = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.ScriptLink @__BuildControlScriptLink3() {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.ScriptLink();
            this.ScriptLink3 = @__ctrl;
            @__ctrl.ID = "ScriptLink3";
            @__ctrl.Name = "/_layouts/15/SharePointTabify/js/jquery.cookie.1.4.1.min.js";
            @__ctrl.Localizable = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.ScriptLink @__BuildControlScriptLink4() {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.ScriptLink();
            this.ScriptLink4 = @__ctrl;
            @__ctrl.ID = "ScriptLink4";
            @__ctrl.Name = "/_layouts/15/SharePointTabify/js/jqueryTabs.js";
            @__ctrl.Localizable = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::SharePointTabify.Tabify.Tabify @__ctrl) {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl1;
            @__ctrl1 = this.@__BuildControlScriptLink1();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl2;
            @__ctrl2 = this.@__BuildControlScriptLink2();
            @__parser.AddParsedSubObject(@__ctrl2);
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl3;
            @__ctrl3 = this.@__BuildControlScriptLink3();
            @__parser.AddParsedSubObject(@__ctrl3);
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl4;
            @__ctrl4 = this.@__BuildControlScriptLink4();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__ctrl.SetRenderMethodDelegate(new System.Web.UI.RenderMethod(this.@__Render__control1));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__Render__control1(System.Web.UI.HtmlTextWriter @__w, System.Web.UI.Control parameterContainer) {
            parameterContainer.Controls[0].RenderControl(@__w);
            @__w.Write(" \r\n");
            parameterContainer.Controls[1].RenderControl(@__w);
            @__w.Write("\r\n");
            parameterContainer.Controls[2].RenderControl(@__w);
            @__w.Write("\r\n");
            parameterContainer.Controls[3].RenderControl(@__w);
            @__w.Write("\r\n");
   if ((SPContext.Current.FormContext.FormMode == SPControlMode.Edit) || (HttpContext.Current.Request.Url.ToString().Contains("?PageView=")))
    { // Shell to Raw HTML//
            @__w.Write("\r\n        <h3>This Page is in edit mode.<br />Save the page to view your chages.<" +
                    "/h3>\r\n");
  //ASPNET// 
    }
//ASPNET Closed//

            @__w.Write("\r\n\r\n<div id=\"tabsContainer\"></div>\r\n");
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}