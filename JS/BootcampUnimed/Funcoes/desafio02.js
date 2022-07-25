let x = "vertebrado"; 
let y = "mamifero"; 
let z = "onivoro"; 

const erro = "Esta característica não existe.";

switch (x) {
	case "vertebrado": 
	  switch (y){
	    case "ave": 
	      if(z==="carnivoro"){
	        console.log("aguia");
	      }else{
	        console.log("pomba");
	      }
	      break;
	    case "mamifero": 
	      if(z==="onivoro"){
	        console.log("homem");
	      }else{
	        console.log("vaca");
	      } 
          break;
	    default: console.log(erro);
	  }
	  break;
	case "invertebrado": 
	  switch (y){
	    case "inseto": 
	      if(z==="hematofago"){
	        console.log("pulga");
	      }else{
	        console.log("lagarta");
	      } break;
	    case "anelideo": 
	      if(z==="hematofago"){
	        console.log("sanguessuga");
	      }else{
	        console.log("minhoca");
	      }
	      break;
	    default: console.log(erro);
	  }
	  break;
  default: console.log(erro);
}

console.log(`${x}\n${y}\n${z}\n`)