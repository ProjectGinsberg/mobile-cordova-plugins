var cordova = require('cordova'),
    GinsbergPlugin = require('./GinsbergPlugin');

module.exports = {

    exitApp: function (successCallback, errorCallback) {
		console.log("GP JS: ExitApp Start");
		GinsbergPluginComponent.ManagedCalls.exitApp();
		console.log("GP JS: ExitApp End");
    }
};

require("cordova/exec/proxy").add("GinsbergPlugin", module.exports);
