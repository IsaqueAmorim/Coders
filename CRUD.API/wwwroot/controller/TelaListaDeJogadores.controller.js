sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "../model/formatter",
	"sap/ui/model/Filter",
	"sap/ui/model/FilterOperator",
	"sap/ui/model/json/JSONModel",
 ], function (Controller,formatter,Filter,FilterOperator,JSONModel) {
    "use strict";
    return Controller.extend("sap.ui.api.jogadores.controller.TelaListaDeJogadores", {
        formatter : formatter,
        aoDigitar: function (oEvent) {
			
			let filtro = [];
			let buscar = oEvent.getParameter("query");
			if(buscar){
				filtro.push(new Filter("nome", FilterOperator.Contains, buscar));
			}

			let tabela = this.byId("tabela_jogadores")
			let items = tabela.getBinding("items");
			items.filter(filtro);
			
		},
		onInit : function(){

			this.obterDados();


		},
		obterDados: function(){

			let jsonModelJogador = new JSONModel();
			fetch("https://localhost:7139/v1/jogadores/",{method: "GET"})
				.then(response => response.json())
				.then(response => jsonModelJogador.setData({jogadores : response}))
			this.getView().setModel(jsonModelJogador);
		},
		aoClicarNaLinha : function (EventoDeClique){
			let rota = this.getOwnerComponent().getRouter();
			let idDaLinha = EventoDeClique.getSource().getBindingContext().getProperty("id")
			rota.navTo("detalhes", {id: idDaLinha});
		},
		aoClicarEmAdicionar: function(){
			let rota = this.getOwnerComponent().getRouter();
			rota.navTo("cadastro")
		}
    });
 });
 
