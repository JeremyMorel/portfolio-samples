﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LitigationManagementWebParts.LitigationMatterSummary {
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
    
    
    public partial class LitigationMatterSummary {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::Microsoft.SharePoint.WebControls.ScriptLink propertiesEditor;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView Summary;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Literal editLink;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(LitigationMatterSummary target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::Microsoft.SharePoint.WebControls.ScriptLink @__BuildControlpropertiesEditor() {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl;
            @__ctrl = new global::Microsoft.SharePoint.WebControls.ScriptLink();
            this.propertiesEditor = @__ctrl;
            @__ctrl.ID = "propertiesEditor";
            @__ctrl.Localizable = false;
            @__ctrl.Name = "/_layouts/15/LitigationManagementWebParts/js/propertiesEditor.js";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = global::System.Drawing.Color.White;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control3(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(36, 97, 191)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control4(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(80, 124, 209)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control5(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(80, 124, 209)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.Solid;
            @__ctrl.BorderColor = global::System.Drawing.Color.Black;
            @__ctrl.BorderWidth = new System.Web.UI.WebControls.Unit(1D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control6(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(36, 97, 191)));
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control7(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(239, 243, 251)));
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.Solid;
            @__ctrl.BorderColor = global::System.Drawing.Color.Black;
            @__ctrl.BorderWidth = new System.Web.UI.WebControls.Unit(1D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control8(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(209, 221, 241)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(51, 51, 51)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control9(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(245, 247, 251)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control10(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(109, 149, 225)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control11(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(233, 235, 239)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControl__control12(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(72, 112, 190)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlSummary() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.Summary = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Summary";
            @__ctrl.CellPadding = 8;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(51, 51, 51)));
            @__ctrl.GridLines = global::System.Web.UI.WebControls.GridLines.Both;
            @__ctrl.BorderStyle = global::System.Web.UI.WebControls.BorderStyle.Solid;
            @__ctrl.BorderColor = global::System.Drawing.Color.Black;
            @__ctrl.BorderWidth = new System.Web.UI.WebControls.Unit(1D, global::System.Web.UI.WebControls.UnitType.Pixel);
            this.@__BuildControl__control2(@__ctrl.AlternatingRowStyle);
            this.@__BuildControl__control3(@__ctrl.EditRowStyle);
            this.@__BuildControl__control4(@__ctrl.FooterStyle);
            this.@__BuildControl__control5(@__ctrl.HeaderStyle);
            this.@__BuildControl__control6(@__ctrl.PagerStyle);
            this.@__BuildControl__control7(@__ctrl.RowStyle);
            this.@__BuildControl__control8(@__ctrl.SelectedRowStyle);
            this.@__BuildControl__control9(@__ctrl.SortedAscendingCellStyle);
            this.@__BuildControl__control10(@__ctrl.SortedAscendingHeaderStyle);
            this.@__BuildControl__control11(@__ctrl.SortedDescendingCellStyle);
            this.@__BuildControl__control12(@__ctrl.SortedDescendingHeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Literal @__BuildControleditLink() {
            global::System.Web.UI.WebControls.Literal @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Literal();
            this.editLink = @__ctrl;
            @__ctrl.ID = "editLink";
            @__ctrl.Text = "<font color=silver><i>These properties are controlled via ClaimCenter and cannot " +
                "be changed here.</i></font>";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::LitigationManagementWebParts.LitigationMatterSummary.LitigationMatterSummary @__ctrl) {
            global::Microsoft.SharePoint.WebControls.ScriptLink @__ctrl1;
            @__ctrl1 = this.@__BuildControlpropertiesEditor();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.GridView @__ctrl2;
            @__ctrl2 = this.@__BuildControlSummary();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
            global::System.Web.UI.WebControls.Literal @__ctrl3;
            @__ctrl3 = this.@__BuildControleditLink();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n"));
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
