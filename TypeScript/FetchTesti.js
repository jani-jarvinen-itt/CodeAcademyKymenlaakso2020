var fetchApi = require("node-fetch");
function haeAlbumit(käsittely) {
    fetchApi('https://jsonplaceholder.typicode.com/albums')
        .then(function (response) { return response.json(); })
        .then(function (json) {
        for (var _i = 0, json_1 = json; _i < json_1.length; _i++) {
            var albumi = json_1[_i];
            käsittely(albumi);
        }
    });
}
// haeAlbumit((a) => console.log(a.title));
haeAlbumit(function (a) {
    if (a.id > 80) {
        console.log(a.id);
    }
});
