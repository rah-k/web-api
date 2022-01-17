<script>

    let Name;
    let Skill;
    let Experience;
   
    import { createEventDispatcher } from "svelte";
   let dispatch = createEventDispatcher();

   const personclick=()=>{
 const person={
   Name,
   Skill,
   Experience,
   
   id:Math.random()
 };
 dispatch('addperson', person);
 }
</script>
<div>
    <h3>Add New Person</h3>
    <form on on:submit|preventDefault={personclick}>
    <input  type="text" placeholder="Name" bind:value={Name}><br><br>
    <input type="text" placeholder="Skill" bind:value={Skill}><br><br>
    <input type="text" placeholder="Year of experience" bind:value={Experience}><br><br>
    
    <button>Submit</button>
    </form>

</div>
<style>

    input{
        border-radius: 10px;
        border-color: rgba(6, 115, 240, 0.815);
    }
    button{
        background: orangered;
        color: white;
        border-radius: 10px;
    }

</style>