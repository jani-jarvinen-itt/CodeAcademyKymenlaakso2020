const fetchApi = require("node-fetch");

interface YksiAlbumi {
    userId: number;
    id: number;
    title: string;
}

type AlbuminKäsittelijä = (a: YksiAlbumi) => void;

function haeAlbumit(käsittely: AlbuminKäsittelijä) {
    fetchApi('https://jsonplaceholder.typicode.com/albums')
        .then(response => response.json())
        .then((json: YksiAlbumi[]) => {
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
