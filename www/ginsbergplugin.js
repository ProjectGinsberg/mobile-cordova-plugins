var GinsbergPlugin = {
    showy: function (successCallback, errorCallback, strInput) {
        cordova.exec(successCallback, errorCallback, "GinsbergPlugin", "showy", [strInput]);
    }
}

module.exports = GinsbergPlugin;