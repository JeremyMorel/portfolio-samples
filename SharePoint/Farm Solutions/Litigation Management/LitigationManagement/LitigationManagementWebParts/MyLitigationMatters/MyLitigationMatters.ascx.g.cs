﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LitigationManagementWebParts.MyLitigationMatters {
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
    
    
    public partial class MyLitigationMatters {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal script;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal style;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal MyMatters;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal NotMyMatters;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(MyLitigationMatters target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Literal @__BuildControlscript() {
            global::System.Web.UI.WebControls.Literal @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Literal();
            this.script = @__ctrl;
            @__ctrl.ID = "script";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Literal @__BuildControlstyle() {
            global::System.Web.UI.WebControls.Literal @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Literal();
            this.style = @__ctrl;
            @__ctrl.ID = "style";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Literal @__BuildControlMyMatters() {
            global::System.Web.UI.WebControls.Literal @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Literal();
            this.MyMatters = @__ctrl;
            @__ctrl.ID = "MyMatters";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Literal @__BuildControlNotMyMatters() {
            global::System.Web.UI.WebControls.Literal @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Literal();
            this.NotMyMatters = @__ctrl;
            @__ctrl.ID = "NotMyMatters";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::LitigationManagementWebParts.MyLitigationMatters.MyLitigationMatters @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<script type=\"text/javascript\" src=\"//code.jquery.com/ui/1.12.1/jquery-ui.min.j" +
                        "s\"></script>\r\n<script>$(function () { $(\"#accordion\").accordion({ collapsible: t" +
                        "rue, active: false }); });  </script>\r\n"));
            global::System.Web.UI.WebControls.Literal @__ctrl1;
            @__ctrl1 = this.@__BuildControlscript();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.Literal @__ctrl2;
            @__ctrl2 = this.@__BuildControlstyle();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<div id=\"accordion\">\r\n  <div>My Matters</div>\r\n    <div>\r\n        "));
            global::System.Web.UI.WebControls.Literal @__ctrl3;
            @__ctrl3 = this.@__BuildControlMyMatters();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n  <div>Matters I\'m contributing to</div>\r\n    <div>\r\n        "));
            global::System.Web.UI.WebControls.Literal @__ctrl4;
            @__ctrl4 = this.@__BuildControlNotMyMatters();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n</div>\r\n"));
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
