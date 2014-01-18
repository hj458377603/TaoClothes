<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TaoClothes.UI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css/default.css" rel="stylesheet" />
    <script src="js/jquery-1.7.1.js"></script>
    <title>商品详情页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            商品详情页
        </div>

        <div id="main">
            <div id="product-section">
                <div id="product-img">
                    <img id="productPic" src="img/1.jpg" alt="商品图片" runat="server" />
                </div>
                <div id="product-summary">
                    <asp:Label ID="productName" runat="server" />
                </div>
                <div id="product-price">
                    <div id="old-price">
                        <del>原价：¥<asp:Label ID="marketPrice" runat="server" /></del>
                    </div>
                    <div id="promotion-price">
                        <b>促销价</b>：<span>¥<asp:Label ID="price" runat="server" /></span>
                    </div>
                </div>
                <div id="store">
                    库存：<span><asp:Label ID="storeNum" runat="server" /></span>
                </div>
                <div id="color">
                    <span>颜色：</span>
                    <asp:ListView runat="server" ID="ColorList">
                        <ItemTemplate>
                            <a class="selectItem"><%# Eval("attr_value") %></a>
                        </ItemTemplate>
                    </asp:ListView>
                </div>

                <div id="size">
                    <span>尺寸：</span>
                    <asp:ListView runat="server" ID="SizeList">
                        <ItemTemplate>
                            <a class="selectItem"><%# Eval("attr_value") %></a>
                        </ItemTemplate>
                    </asp:ListView>
                </div>

                <div id="buy">
                    <a href="javascript:void(0)">立即购买</a>
                </div>
                <div id="description">
                    <a id="descriptionTitle" href="javascript:void(0)">点击查看商品详情</a>
                </div>

                <div id="descriptionContent" runat="server"></div>
            </div>
        </div>
    </form>
    <script type="text/ecmascript">
        $("#color a").each(function (index, item) {
            item.onclick = function () {
                $("#color .selectedItem").each(function (index, selectedItem) {
                    selectedItem.className = "selectItem";
                });
                item.className = "selectedItem";
            }
        });

        $("#size a").each(function (index, item) {
            item.onclick = function () {
                $("#size .selectedItem").each(function (index, selectedItem) {
                    selectedItem.className = "selectItem";
                });
                item.className = "selectedItem";
            }
        });

        // 检查颜色的选中项
        function checkColorSelected() {
            var isSelected = false;
            $("#color a").each(function (index, item) {
                if (item.className == "selectedItem") {
                    isSelected = true;
                }
            });
            return isSelected;
        }

        // 检查尺寸的选中项
        function checkSizeSelected() {
            var isSelected = false;
            $("#size a").each(function (index, item) {
                if (item.className == "selectedItem") {
                    isSelected = true;
                }
            });
            return isSelected;
        }

        $("#buy").click(function () {
            if (!checkColorSelected()) {
                alert("请选择颜色");
            }
            else
                if (!checkSizeSelected()) {
                    alert("请选择尺寸");
                }
        });
    </script>
</body>
</html>
