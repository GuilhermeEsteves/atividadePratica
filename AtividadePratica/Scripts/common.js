function formatMoeda(number, c, d, t) {
    var n = number, c = isNaN(c = Math.abs(c))
        ? 2
        : c, d = d == undefined
            ? ","
            : d, t = t == undefined
                ? "."
                : t, s = n < 0 ? "-"
                : "", i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "", j = (j = i.length) > 3 ? j % 3 : 0;
    return s + (j ? i.substr(0, j) + t : "")
        + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
};

function formatData(data) {
    var dataQuebrada = data.split('/');
    return dataQuebrada[1] + "/" + dataQuebrada[0] + "/" + dataQuebrada[2];
}

function comparaDataAtual(data) {
    var partesData = data.split("/");
    var data = new Date(partesData[2], partesData[1] - 1, partesData[0]);

    if (data < new Date())
        return false;

    return true;
}

function checarDatas(data1 ,data2) {

    if ((data1 == null || data1 == "") || (data2 == null || data2 == ""))
        return;

    var nova_data1 = parseInt(data1.split("/")[2].toString() + data1.split("/")[1].toString() + data1.split("/")[0].toString());
    var nova_data2 = parseInt(data2.split("/")[2].toString() + data2.split("/")[1].toString() + data2.split("/")[0].toString());

    if (nova_data1 > nova_data2)
        return true;

    return false;
}

function checarDataAual(data1) {
    return checarDatas(getDataAtual(),data1);
}

function getDataAtual() {
    var today = new Date();
    var dd = today.getDate();
    var mm = today.getMonth() + 1;
    var yyyy = today.getFullYear();

    if (dd < 10) {
        dd = '0' + dd
    }

    if (mm < 10) {
        mm = '0' + mm
    }

    return dd + '/' + mm + '/' + yyyy;
}

function validaData(data) {
    var dia = data.substring(0, 2)
    var mes = data.substring(3, 5)
    var ano = data.substring(6, 10)

    //Criando um objeto Date usando os valores ano, mes e dia.
    var novaData = new Date(ano, (mes - 1), dia);

    var mesmoDia = parseInt(dia, 10) == parseInt(novaData.getDate());
    var mesmoMes = parseInt(mes, 10) == parseInt(novaData.getMonth()) + 1;
    var mesmoAno = parseInt(ano) == parseInt(novaData.getFullYear());

    if (!((mesmoDia) && (mesmoMes) && (mesmoAno))) {
        return false;
    }
    return true;
}
