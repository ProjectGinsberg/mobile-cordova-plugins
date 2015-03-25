var GinsbergPlugin = {
    exitApp: function (successCallback, errorCallback) {
        cordova.exec(successCallback, errorCallback, "GinsbergPlugin", "exitApp", []);
    }
}

module.exports = GinsbergPlugin;