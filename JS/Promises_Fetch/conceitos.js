const EventEmitter = require('events');

class Users extends EventEmitter {
    userLogged(data){
        this.emit('User logged', data);
    }
}

const users = new Users();

users.on('User logged', data => {
    console.log(data);
});


//emitter.emit('User logged', {user: 'Celso Henrique'});

users.userLogged({user: 'Celso Henrique'});