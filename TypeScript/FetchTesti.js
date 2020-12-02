const fetchApi = require("node-fetch");
function haeAlbumit(käsittely) {
    fetchApi('https://jsonplaceholder.typicode.com/albums')
        .then(response => response.json())
        .then((json) => {
        for (const albumi of json) {
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
