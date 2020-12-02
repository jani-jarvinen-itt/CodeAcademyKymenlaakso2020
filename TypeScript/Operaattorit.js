const arvo = {
    id: 1234
};
// optional chaining
const teksti = arvo?.id?.toString();
// nullish coalescing
const tulos = teksti ?? "(tuntematon)";
