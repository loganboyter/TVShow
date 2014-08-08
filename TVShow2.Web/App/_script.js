//This was the main script before we pulled in angular



var masterAjax = function (method, url, data, success) {
    var request = new XMLHttpRequest();
    request.open(method, url);
    request.onload = function () {
        if (this.status >= 200 && this.status < 400) {
            if (this.response !== "") success(JSON.parse(this.response));
            else success();
        }
        else console.log("Error on " + method + ": " + this.response);
    }
    request.onerror = function () {
        console.log("Comm error on" + method);
    }
    if (data) { request.send(JSON.stringify(data)); }
    else { request.send(); }
}

var submitShow = function () {
    var title = document.getElementById("title").value;
    var description = document.getElementById("description").value;
    var obj = { Title: title, Description: description }
    masterAjax("POST", "/api/v1/TvShow", obj, getShows);
}






var getShows = function () {
    masterAjax("GET", "/api/v1/TvShow", null, function (data) {
        console.log("Callback called");
        var holder = "";
        data.forEach(function (show) {
            holder += show.Title + "<br />";
        });
        document.getElementById("result").innerHTML = holder;
    })
}

getShows();