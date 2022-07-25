/*interface IAnimal {
    nome: string;
    tipo: 'terrestre' | 'aquático';

    rugir(som: string): void;
}

interface IFelino extends IAnimal {
    visaoNoturna: boolean;
}

const animal: IAnimal = {
    nome: 'Elefante',
    tipo: 'terrestre',
    rugir(som: string): void{
        console.log(som);
    }
}

const felino: IFelino = {
    nome: 'Puma',
    tipo: 'terrestre',
    visaoNoturna: true,
    rugir: (som) => (`${som}`)
}
*/
//console.log(felino.rugir('Aarrr Uhh!'));

const input = document.getElementById('input') as HTMLInputElement;
input.addEventListener('input', (event) => {
    const i = event.currentTarget as HTMLInputElement;
    console.log(i.value);
})

// Generics Types
function appendLista<T>(array: T[], value: T){
    return array.map(() => value);
}

appendLista([1,2,3,4,5], 1);

//===========