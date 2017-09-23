$(function () {
    myfunction();
})
function myfunction() {
    var qty = document.getElementById("qty").innerText;
    if (qty == "暂时缺货") {
        document.getElementById('shop').setAttribute("readonly", "true");
        document.getElementById('shop').setAttribute("placeholder", "该商品缺货暂时无法购买");
    }
}
