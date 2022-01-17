<script>

	
import Footer from "./footer.svelte"
	import Login from "./login.svelte"
	import Tab from "./tab.svelte";
  import Model from "./conditional.svelte";
  import App from "./addperson.svelte";
  let showModel=false;
  let people=[
{Name:'Yoshi',Skill:'Java Developer',Experience:5,id:1},
{Name:'Jerry ',Skill:'C# Developer',Experience:4,id:2},
{Name:'Tom',Skill:'.net  Developer',Experience:3,id:3},
{Name:'Nick',Skill:'Java Developer',Experience:7,id:4},
{Name:'Sam',Skill:'Frontend Developer',Experience:10,id:5}
];
  
const toggleclick =()=>{
    showModel = !showModel;
}
const addperson=(e)=>{
  console.log(e.detail);
  const person = e.detail;
  people = [person, ...people];
 
 };
 const handleclick =(id)=>{
   people = people.filter((person)=>person.id != id);
}
let items =['Todo','Working','completed'];
let activeItem='Todo';
const tabchange=(e)=>{
  activeItem=e.detail;
}
</script>


	
	<header>
		<ul>
			<li><a href="/"> Home</a></li>
			<li><a href="/about">About</a></li>
			<li><a href="/account">My Account</a></li>
		</ul>
	</header>

<main>
  <button on:click={toggleclick}> Click</button>
	<Model  {showModel} on:click={toggleclick} >
    <App on:addperson={addperson}/>
    
  </Model>
 
  <Login />
    <h2>Employeee Detials</h2>
   
    {#each people as person(person.id)}
   
    <div>
       
        <h4>{person.Name}</h4>
        <p> He is {person.Skill} and he have a {person.Experience} year experience</p>
        <button on:click={()=>{handleclick(person.id)}}> Delete </button>
    </div>
    {:else}
    <p>there is no employee</p>
    
   
    {/each}
  

  
 
 
 
 <Tab {activeItem}{items} on:tabchange={tabchange}/>
 {#if activeItem === 'Todo'}
 <p>You are in todo state</p>
 <h1>Login page</h1>
 <input type="text">
 <input type="password">
 {:else if activeItem ==='Working'}
 <p>You are in working state</p>
 {:else}
 <p>You are in completed state</p>
 {/if}

		
</main>

<Footer/>



<style>
	main {
		text-align: center;
		padding: 1em;
		max-width: 240px;
		margin: 0 auto;
	}
	header{
    background:gray;
    width:1800px;
    height: 60px;
    
}
h4{
        color: red;
    }

ul{
    list-style-type: none;
    margin: 0;
  padding: 2;
  overflow: hidden;
  
}
li{
    float: left;
    
}
li a{
    display: block;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}
	
	

	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>