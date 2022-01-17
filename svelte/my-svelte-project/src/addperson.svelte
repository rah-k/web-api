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
    <input type="text" placeholder="Name" bind:value={Name}>
    <input type="text" placeholder="Skill" bind:value={Skill}><br>
    <input type="number" placeholder="Year of experience" bind:value={Experience}><br>
    <button>Submit</button>
    </form>

</div>
<style>
  button{
        background: cornflowerblue;
        color:white;
    }

</style>