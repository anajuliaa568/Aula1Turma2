/* Ao carregar nosso site por completo executa o conteudo do $(document).ready()*/
var MeuCachorro = {
    nome: "People",
    idade: 4,
    coloracao: "branco",
    raca: "Poodle"
};

$(document).ready(
    function () {
        /* Carrego defaul name */
        $('input[name="Nome"]').val(MeuCachorro.nome);
        $('input[name="Idade"]').val(MeuCachorro.idade);
        $('input[name=" Raca"]').val(MeuCachorro.raca);
        $('input[name="Coloracao"]').val(MeuCachorro.coloracao);


        $('input[name="bntsalvar"]').click(function () {
            MeuUsuario.nome = $('input[name="nomeusuario"]').val();
        });

        $('input[name="bntmostrar"]').click(function () {
            alert(MeuUsuario.nome);
        });

       
    }
);