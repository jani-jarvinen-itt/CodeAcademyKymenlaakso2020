const fetch = require("node-fetch");

function haeAlbumit(käsittely) {
    fetch('https://jsonplaceholder.typicode.com/albums')
        .then(response => response.json())
        .then(json => {
            for (albumi of json) {
                käsittely(albumi);
            }
        });
}

// haeAlbumit((a) => console.log(a.title));
haeAlbumit((a) => {
    if (a.id > 80) {
        console.log(a.id);
    }
});
