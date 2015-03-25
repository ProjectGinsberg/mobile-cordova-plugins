var cordova = require('cordova'),
    GinsbergPlugin = require('./GinsbergPlugin');

module.exports = {

    showy: function (successCallback, errorCallback, strInput) {
		console.log("sdgsg");
		/*
        var upperCase = strInput[0].toUpperCase();
        if(upperCase != "") {
            successCallback(upperCase);
        }
        else {
            errorCallback(upperCase);
        }
		*/
		
		var ex1 = GinsbergPluginComponent.ManagedCalls.getAnswer();

		//var ex2 = new SampleComponent.Example();

		var ex3 = ex1.sampleProperty;
    }
};

require("cordova/exec/proxy").add("GinsbergPlugin", module.exports);
