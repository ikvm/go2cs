﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace go2cs.Templates
{
    using System.Collections.Generic;
    using System.Linq;
    using go2cs.Metadata;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class StructTypeTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
 // This template creates a <PackageName>_<StructName>Struct.cs file 
            
            #line default
            #line hidden
            this.Write(@"//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on ");
            
            #line 13 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedTime));
            
            #line default
            #line hidden
            this.Write("\r\n// </auto-generated>\r\n//-------------------------------------------------------" +
                    "--\r\nusing System;\r\nusing System.CodeDom.Compiler;\r\nusing System.Runtime.Compiler" +
                    "Services;\r\n");
            
            #line 19 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(Environment.NewLine, UsingStatements)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 20 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
if (!NamespacePrefix.Equals("go")) {
            
            #line default
            #line hidden
            this.Write("using go;\r\n");
            
            #line 22 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 24 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespaceHeader));
            
            #line default
            #line hidden
            this.Write("\r\n    public static partial class ");
            
            #line 25 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package\r\n    {\r\n        [");
            
            #line 27 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            
            #line default
            #line hidden
            this.Write("]");
            
            #line 27 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

        foreach (string promotedStruct in PromotedStructs)
        {
            if (!string.IsNullOrEmpty(promotedStruct))
            {
        
            
            #line default
            #line hidden
            this.Write("\r\n        [PromotedStruct(typeof(");
            
            #line 34 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(promotedStruct));
            
            #line default
            #line hidden
            this.Write("))]");
            
            #line 34 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

            }
        }
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 38 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Scope));
            
            #line default
            #line hidden
            this.Write(" partial struct ");
            
            #line 38 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("\r\n        {");
            
            #line 39 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

            foreach (KeyValuePair<string, List<FunctionSignature>> kvp in PromotedFunctions)
            {
                foreach (var decl in kvp.Value)
                {
                    
            
            #line default
            #line hidden
            
            #line 44 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new StructFuncDeclTemplate
                    {
                        PromotedField = kvp.Key,
                        FunctionName = decl.Name,
                        Scope = "public",
                        ParameterSignature = decl.Signature.GenerateParametersSignature(false),
                        ParameterNames = GetParameterNames(decl),
                        ParameterTypes = GetParameterTypes(decl),
                        ResultType = decl.Signature.GenerateResultSignature()
                    }
                    .TransformText()));
            
            #line default
            #line hidden
            
            #line 54 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                }
            }

            foreach (KeyValuePair<string, List<FieldInfo>> kvp in PromotedFields)
            {

                FieldInfo promotedStruct = GetPromotedStruct(kvp.Key);
                bool isPointer = promotedStruct?.Type.IsPointer ?? false;
            
            
            #line default
            #line hidden
            this.Write("\r\n            // ");
            
            #line 65 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write(" structure promotion - sourced from ");
            
            #line 65 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(isPointer ? "pointer" : "value copy"));
            
            #line default
            #line hidden
            this.Write("\r\n            private readonly Ref<");
            
            #line 66 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write("> m_");
            
            #line 66 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write("Ref;\r\n\r\n            private ref ");
            
            #line 68 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 68 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write("_");
            
            #line 68 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(isPointer ? "ptr" : "val"));
            
            #line default
            #line hidden
            this.Write(" => ref m_");
            
            #line 68 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write("Ref.Value;\r\n");
            
            #line 69 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"


                foreach (var decl in kvp.Value)
                {
                
            
            #line default
            #line hidden
            this.Write("\r\n            public ref ");
            
            #line 75 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Type.PrimitiveName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 75 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write(" => ref m_");
            
            #line 75 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(kvp.Key));
            
            #line default
            #line hidden
            this.Write("Ref.Value.");
            
            #line 75 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 76 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                }
            }
            
            if (PromotedFunctions.Count > 0)
            {
            
            
            #line default
            #line hidden
            this.Write("            \r\n            [DebuggerStepperBoundary]\r\n            static ");
            
            #line 85 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("()\r\n            {\r\n                Type targetType = typeof(");
            
            #line 87 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(");\r\n                MethodInfo extensionMethod;");
            
            #line 88 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"


                foreach (KeyValuePair<string, List<FunctionSignature>> kvp in PromotedFunctions)
                {
                    foreach (var decl in kvp.Value)
                    {
                        
            
            #line default
            #line hidden
            
            #line 94 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new StructFuncInitTemplate
                        {
                            FunctionName = decl.Name
                        }
                        .TransformText()));
            
            #line default
            #line hidden
            
            #line 98 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                    }
                }
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n");
            
            #line 103 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

            
            }
            
            #line default
            #line hidden
            this.Write("\r\n            // Constructors\r\n            public ");
            
            #line 108 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(NilType _)\r\n            {");
            
            #line 109 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

            foreach (var decl in StructFields)
            {
                if (PromotedStructs.Contains(decl.Type.PrimitiveName))
                {
                    // Promoted struct 
            
            #line default
            #line hidden
            this.Write("\r\n                this.m_");
            
            #line 116 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write("Ref = new Ref<");
            
            #line 116 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Type.PrimitiveName));
            
            #line default
            #line hidden
            this.Write(">(new ");
            
            #line 116 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Type.PrimitiveName));
            
            #line default
            #line hidden
            this.Write("(nil));");
            
            #line 116 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                }
                else
                {
                    // Promoted interface or normal struct field 
            
            #line default
            #line hidden
            this.Write("\r\n                this.");
            
            #line 122 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write(" = default;");
            
            #line 122 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                }
            }
            
            #line default
            #line hidden
            this.Write("\r\n            }");
            
            #line 126 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
 
            
            if (StructFields.Length > 0)
            {
            
            #line default
            #line hidden
            this.Write("\r\n\r\n            public ");
            
            #line 132 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 132 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", StructFields.Select(field => $"{(field.Type.IsPointer ? "ref " : "")}{field.Type.PrimitiveName} {field.Name}"))));
            
            #line default
            #line hidden
            this.Write(")\r\n            {");
            
            #line 133 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

            foreach (var decl in StructFields)
            {
                if (PromotedStructs.Contains(decl.Type.PrimitiveName))
                {
                    // Promoted struct 
            
            #line default
            #line hidden
            this.Write("\r\n                this.m_");
            
            #line 140 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write("Ref = new Ref<");
            
            #line 140 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Type.PrimitiveName));
            
            #line default
            #line hidden
            this.Write(">(");
            
            #line 140 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Type.IsPointer ? "ref " : ""));
            
            #line default
            #line hidden
            
            #line 140 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write(");");
            
            #line 140 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                }
                else
                {
                    // Promoted interface or normal struct field 
            
            #line default
            #line hidden
            this.Write("\r\n                this.");
            
            #line 146 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 146 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(decl.Name));
            
            #line default
            #line hidden
            this.Write(";");
            
            #line 146 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

                }
            }
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n");
            
            #line 151 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

            }
            
            #line default
            #line hidden
            this.Write("\r\n            // Enable comparisons between nil and ");
            
            #line 154 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" struct\r\n            [MethodImpl(MethodImplOptions.AggressiveInlining)]\r\n        " +
                    "    public static bool operator ==(");
            
            #line 156 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value, NilType nil) => value.Equals(default(");
            
            #line 156 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("));\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveInlining)]\r\n          " +
                    "  public static bool operator !=(");
            
            #line 159 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value, NilType nil) => !(value == nil);\r\n\r\n            [MethodImpl(MethodImplOpt" +
                    "ions.AggressiveInlining)]\r\n            public static bool operator ==(NilType ni" +
                    "l, ");
            
            #line 162 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value) => value == nil;\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveI" +
                    "nlining)]\r\n            public static bool operator !=(NilType nil, ");
            
            #line 165 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(" value) => value != nil;\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveI" +
                    "nlining)]\r\n            public static implicit operator ");
            
            #line 168 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write("(NilType nil) => default(");
            
            #line 168 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StructName));
            
            #line default
            #line hidden
            this.Write(");\r\n        }\r\n    }\r\n");
            
            #line 171 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespaceFooter));
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 171 "D:\Projects\go2cs\src\go2cs\Templates\StructTypeTemplate.tt"

// Template Parameters
public string NamespacePrefix;
public string NamespaceHeader;
public string NamespaceFooter;
public string PackageName;
public string StructName;
public string Scope;
public FieldInfo[] StructFields;
public HashSet<string> PromotedStructs;
public Dictionary<string, List<FunctionSignature>> PromotedFunctions;
public Dictionary<string, List<FieldInfo>> PromotedFields;
public IEnumerable<string> UsingStatements;

private string GetParameterNames(FunctionSignature function)
{
    string parameterNames = function.GetParameterNames();

    if (parameterNames.Length > 0)
        parameterNames = ", " + parameterNames;

    return parameterNames;
}

private string GetParameterTypes(FunctionSignature function)
{
    string parameterTypes = function.GetParameterTypes();

    if (parameterTypes.Length > 0)
        parameterTypes = ", " + parameterTypes;

    return parameterTypes;
}

private FieldInfo GetPromotedStruct(string fieldName)
{
    foreach (FieldInfo field in StructFields)
    {
        if (field.Name.Equals(fieldName, StringComparison.Ordinal))
            return field;
    }

    return null;
}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
