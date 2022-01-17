<script>
  let people=[
{Name:'Yoshi',Skill:'Java Developer',Experience:'5 years',id:1},
{Name:'Jerry ',Skill:'C# Developer',Experience:'4 years',id:2},
{Name:'Tom',Skill:'.net  Developer',Experience:'5 years',id:3},
{Name:'Nick',Skill:'Java Developer',Experience:'5 years',id:4},
{Name:'Sam',Skill:'Frontend Developer',Experience:'5 years',id:5}
];

const handleclick =(id)=>{
   people = people.filter((person)=>person.id != id);
}


</script>
<main>

    <h2>Employeee Detials</h2>
   
    {#each people as person(person.id)}
   
    <div>
       
        <h4>{person.Name}</h4>
        <p> He is {person.Skill} and he have a {person.Experience}</p>
        <button on:click={()=>{handleclick(person.id)}}> Delete </button>
    </div>
    {:else}
    <p>there is no employee</p>
    
   
    {/each}

  
   
</main>
<style>
    h4{
        color: red;
    }

</style>