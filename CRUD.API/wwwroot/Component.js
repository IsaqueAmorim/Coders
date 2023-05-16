sap.ui.define([
	"sap/ui/core/UIComponent",

], function (UIComponent) {
	"use strict";

	return UIComponent.extend("sap.ui.api.jogadores.Component", {

		metadata : {
			interfaces: ["sap.ui.core.IAsyncContentCreation"],
			manifest: "json"
		},

		init : function () {
			// call the init function of the parent
			UIComponent.prototype.init.apply(this, arguments);

			this.getRouter().initialize();
		}
	});

});