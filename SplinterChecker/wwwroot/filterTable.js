function filterTable() {
    var input = document.getElementById("typeFilter");
    var filter = input.value.toUpperCase();
    var table = document.getElementById("dataTable");
    var trs = table.getElementsByTagName("tr");

    for (var i = 0; i < trs.length; i++) {
        var tds = trs[i].getElementsByTagName("td");
        var type = tds[2];
        if (type) {
            var text = type.textContent.toUpperCase();
            if (text.indexOf(filter) > -1) {
                trs[i].style.display = "";
            } else {
                trs[i].style.display = "none";
            }
        }
    }
}
