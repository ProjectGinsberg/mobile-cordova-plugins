var GinsbergPlugin = {
    show: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "GinsbergPlugin", "show", [strInput]);
    }
}

module.exports = GinsbergPlugin;