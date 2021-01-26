function Nappi(props) {

    function nappiaKlikattu(e) {

        e.preventDefault();
        alert("Nappia \"" + props.teksti +
            "\" on klikattu.");
    }

    return (
        <button className="btn btn-primary m-3" onClick={nappiaKlikattu}>
            {props.teksti}
        </button>
    );
}

export default Nappi;
