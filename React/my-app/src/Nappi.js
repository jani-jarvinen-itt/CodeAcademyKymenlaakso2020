function Nappi(props) {

    function nappiaKlikattu(e) {

        e.preventDefault();
        alert("Nappia \"" + props.teksti +
            "\" on klikattu.");
    }

    let värikoodi = "primary";
    if (props.väri) {
        värikoodi = props.väri;
    }

    const napinTyyli = `btn btn-${värikoodi} m-3`;

    return (
        <button className={napinTyyli} onClick={nappiaKlikattu}>
            {props.teksti}
        </button>
    );
}

export default Nappi;
