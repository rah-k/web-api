<script>
	 import Nav from "./Component/Navigation.svelte";
	 
	 import APP from "./Component/addperson.svelte";
	 let people=[
{Name:'Yoshi',Skill:'Java Developer',Experience:5,id:1,photo:'rk.jpg'},
{Name:'Jerry ',Skill:'C# Developer',Experience:4,id:2},
{Name:'Tom',Skill:'.net  Developer',Experience:3,id:3},
{Name:'Nick',Skill:'Java Developer',Experience:7,id:4},
{Name:'Sam',Skill:'Frontend Developer',Experience:10,id:5}
];
	 let items=['Add employee','Employee details']
	 let activeItem='Add employee'
	 

	 const handleclick =(id)=>{
   people = people.filter((person)=>person.id != id);
}
	 const tabchange=(e)=>{
		 activeItem = e.detail;
	 }
	 const addperson=(e)=>{
		 console.log(e.detail)
		const person = e.detail;
  		people = [person, ...people];

	 }
</script>

<main>
	<Nav {activeItem} {items} on:tabchange={tabchange}/>
	{#if activeItem === 'Add employee'}
	<APP  on:addperson={addperson}/>
	{:else if activeItem==='Employee details'}
	{#each people as person(person.id)}
   
    <div>
    
        <h4> {person.Name}</h4>
        <p> He is {person.Skill}  and he have a {person.Experience} year experience</p>
        <button on:click={()=>{handleclick(person.id)}}> Delete </button>
    </div>
    {:else}
    <p>there is no employee</p>
    
   
    {/each}
	{/if}
</main>

<style>
	main {
		text-align: center;
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
		
	}

	h4{
        color:rgb(4, 17, 136);
    }


	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
	button{
		border-radius: 10px;
		background: orangered;
		color: white;
		width: 200px;
	}
</style>