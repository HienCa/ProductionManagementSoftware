#pragma checksum "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef15dd8e361b24b2dcf0463c07e0a872664292ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nhanvien_Index), @"mvc.1.0.view", @"/Views/Nhanvien/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\_ViewImports.cshtml"
using QuanLySanXuat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\_ViewImports.cshtml"
using QuanLySanXuat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
using QuanLySanXuat.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef15dd8e361b24b2dcf0463c07e0a872664292ae", @"/Views/Nhanvien/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4916b992cd2137ba256fd5b3eb4a94d6f8a0136", @"/Views/_ViewImports.cshtml")]
    public class Views_Nhanvien_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLySanXuat.Entities.Nhanvien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Import", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Nhanvien", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px; height:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
  
    Layout = "_Layout";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex"">
    <h2>Quản Lý Nhân Viên</h2>
    <div class=""col-md-3 col-sm-12"">
        <a href=""/Nhanvien/Create"" class=""btn p-2"" style=""background-color: #EDEDED; color: #73879C; font-size:17px"">
            <i class=""fas fa-plus""></i>Thêm mới
        </a>
        <a href=""/Nhanvien/ExportToExcel"" class=""btn ml-2 p-2"" style=""background-color: #EDEDED; color: #73879C; font-size: 17px "">
            <i class=""fas fa-file-excel""></i>
        </a>
        <a href=""/Nhanvien/ExportToPDF"" class=""btn ml-2 p-2"" style=""background-color: #EDEDED; color: #73879C; font-size: 17px "">
            <i class=""fas fa-file-pdf""></i>
        </a>
        <a href=""/Nhanvien/ExportToCSV"" class=""btn ml-2 p-2"" style=""background-color: #EDEDED; color: #73879C; font-size: 17px "">
            <i class=""fas fa-file-csv""></i>
        </a>
    </div>


    <div class=""col-md-3 col-sm-12"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef15dd8e361b24b2dcf0463c07e0a872664292ae7013", async() => {
                WriteLiteral("\r\n            <div class=\" d-flex\">\r\n                <input id=\"fileExcel\"");
                BeginWriteAttribute("class", " class=\"", 1201, "\"", 1209, 0);
                EndWriteAttribute();
                WriteLiteral(" required type=\"file\" name=\"file\" />\r\n                <button class=\"btn\" style=\"background-color: #EDEDED; color: #73879C; font-size: 17px \" type=\"submit\"><i class=\"fas fa-upload\"></i></button>\r\n");
#nullable restore
#line 31 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                 if (ViewData["errorMessage"] != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <label class=\"text-danger\">");
#nullable restore
#line 33 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                                          Write(ViewData["errorMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 34 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>



</div>
<div class=""x_content"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""card-box table-responsive"">


                <table id=""datatable-responsive"" class=""table table-striped table-bordered dt-responsive nowrap""
                       cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr  class=""text-center"">
                            <th>Mã KH</th>
                            <th>Họ và tên</th>
                            <th>Email</th>
                            <th>Địa chỉ</th>
                            <th>Số điện thoại</th>
                            <th>CCCD/CMND</th>
");
            WriteLiteral("                            <th>Giới tính</th>\r\n                            <th>Ngày sinh</th>\r\n");
            WriteLiteral(@"                            <th>Ảnh</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""d-none"">
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>
                            <td>.</td>

                        </tr>
");
#nullable restore
#line 84 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 87 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Manv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 88 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Tennv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 89 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 90 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 91 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 92 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Cccd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                <td>");
#nullable restore
#line 94 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                               Write(item.Gioitinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 95 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                                 if (item.Ngaysinh != null)
                                {
                                    DateTime Ngaysinh = (DateTime)item.Ngaysinh;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 98 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                                   Write(Ngaysinh.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 99 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td></td>\r\n");
#nullable restore
#line 103 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef15dd8e361b24b2dcf0463c07e0a872664292ae15445", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4794, "~/Images/", 4794, 9, true);
#nullable restore
#line 114 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
AddHtmlAttributeValue("", 4803, item.Hinhanh, 4803, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n\r\n                                <td class=\"table-td-center d-flex\">\r\n");
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 5115, "\"", 5147, 2);
            WriteAttributeValue("", 5122, "/Nhanvien/Edit/", 5122, 15, true);
#nullable restore
#line 119 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
WriteAttributeValue("", 5137, item.Idnv, 5137, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btn-sm btn-warning \"><i class=\"fas fa-edit text-white\"></i></a>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef15dd8e361b24b2dcf0463c07e0a872664292ae17719", async() => {
                WriteLiteral("\r\n                                        <button type=\"submit\" class=\"btn  btn-sm btn-danger \"><i class=\"fas fa-trash text-white\"></i></button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                                                                                   WriteLiteral(item.Idnv);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 126 "D:\ĐH-08CNTT1\HienCa\NetFramework\QuanLySanXuat\Views\Nhanvien\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>

            </div>
        </div>
    </div>

</div>
<script>
    let deleteBtns = document.querySelectorAll('.formDelete');
    deleteBtns.forEach(function (deleteBtn) {
        deleteBtn.addEventListener('submit', function (e) {

            var form = this;

            e.preventDefault();

            swal({
                title: 'Bạn có chắc chắn muốn xóa?',

                icon: 'warning',
                buttons: ['Hủy bỏ!', 'Xác nhận'],
                dangerMode: true,
            }).then(function (isConfirm) {
                if (isConfirm) {

                    form.submit();
                    swal({
                        title: 'Đã xóa!',
                        icon: 'success',
                        timer: 1500,
                        button: false,
                    });

                } else {
                    swal({
                        title: 'Đã hủy!',
                        butt");
            WriteLiteral("on: false,\r\n                        icon: \'error\',\r\n                        timer: 500,\r\n                    });\r\n                }\r\n            });\r\n        });\r\n    })\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLySanXuat.Entities.Nhanvien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
