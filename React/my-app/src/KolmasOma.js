function KolmasOma(props) {
    return (
        <div>
            <h2>Kolmas komponentti</h2>
            <p>Tämä on KolmasOma.js</p>
            <p>Teksti on: {props.teksti}</p>
            <p>Luku on: {props.luku}</p>
            <p>Listan pituus: {props.lista?.length}</p>
            <p>Henkilön nimi: {props.henkilö?.nimi}</p>
        </div>
    );
}

export default KolmasOma;
