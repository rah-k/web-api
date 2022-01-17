<script>


    let user ="NewUser"
    let color="black"

const handleinput=(e)=>{
    user=e.target.value;

}

</script>
<main>
    <h1 style="color:{color}">Welcome {user}</h1>
    
  
    <input type="text" bind:value={user}>
    <input type="text" bind:value={color}>
  
</main>

<style>
main{
    max-width: 400px;
        
        border-radius: 10px;
        background: rgb(190, 188, 188);
        margin: 10% auto;
        padding: 5px;
        text-align: center;
}

</style>


