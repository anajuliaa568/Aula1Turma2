
$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var cep = $('input[name="cep"]').val();

                $.get("https://viacep.com.br/ws/" + cep +"/json/", function (data, status) {
                    $('input[name="cidade"]').val(data.localidade);
                    $('input[name="bairro"]').val(data.bairro); 
                    $('input[name="rua"]').val(data.logradouro);
                });

            }
        );
    }
);