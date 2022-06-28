const { match } = require('assert');
const assert = require('assert');
const Math = require('./math');
const expect = require('chai').expect;



describe('Math class', function(){
    it('Sum two numbers', function(done) {
        const math = new Math();
        math.sum(3, 7, value => {
            assert.strictEqual(value, 10);
         done();
        });
    });

    it('Multiply two numers', function() { //Aqui o método .only poderia ser invocado para que apenas essa função fosse testada. Também é possível utilizar o método .skip para pular esta função
        const math = new match();
        assert.strictEqual(math.multiply(5, 5), 25);
    });

});