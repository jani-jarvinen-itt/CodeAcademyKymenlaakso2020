function Nappi(props) {

    function nappiaKlikattu(e) {

        e.preventDefault();
        alert("Nappia \"" + props.teksti +
            "\" on klikattu.");
    }

    return (
        <button onClick={nappiaKlikattu}>
            {props.teksti}
        </button>
    );
}

export default Nappi;
