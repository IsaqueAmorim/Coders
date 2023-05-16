sap.ui.define([
  "sap/ui/core/mvc/Controller",
  "sap/ui/model/json/JSONModel"
], function(Controller,JSONModel) {
    'use strict';
    return Controller.extend("sap.ui.api.jogadores.controller.Cadastro",{
        onInit: function() {
            let JogadorModelo = new JSONModel({});
            this.getView().setModel(JogadorModelo,"jogador");
        },
        abrirSeletorData: function(Evento){
            this.getView().byId("MostrarSeletor").openBy(Evento.getSource().getDomRef());
        },
        aoAlterar: function(Evento){
           let data = Evento.getParameter("value")
           this.getView().byId("BotaoData").data("text", data);
        },
        aoClicarSalvar: function(Event){
            let modelo = this.getView().getModel("jogador").getData();
            let json = {

                nome : modelo.nome,
                sobrenome:modelo.sobrenome,
                apelido: modelo.apelido,
                email:modelo.email,
                elo: parseInt(modelo.elo),
                dataNascimento: modelo.dataNascimento
            }
           
            fetch("https://localhost:7139/v1/jogadores",
            {method:'POST',
            headers: {"Content-Type": "application/json"},
            body:JSON.stringify(json)})
            .then(response => {
                if(response.status == 201){
                    
                }

            });

       
            
            
        }
    });
});