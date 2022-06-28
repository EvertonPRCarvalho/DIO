class CustomError extends Error {
    constructor ({message, data}) {
        super(message);
        this.data = data;
    }
}

try {
    const myError = new CustomError({
        message: 'Custom message',
        data: {
            type: 'Server error'
    }
})
    console.log(name);
    const name = 'Joaquim Maria';
} catch (err){
    console.log('Error: ',err)
} finally {
    console.log('Keep going...');   
}