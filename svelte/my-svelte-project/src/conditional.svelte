<script>
 export let showModel=false;

</script>
{#if showModel}
<div class="dropdown"  on:click|self>
    <div class="model">

<slot></slot>
    </div>
</div>
{/if}
<style>
    .dropdown{
        width:100%;
        height: 100%;
        position: fixed;
        background: rgba(0,0,0,0.8);
    }
    p{
      
    }
    .model{
        max-width: 400px;
        
        border-radius: 10px;
        background: white;
        margin: 10% auto;
        padding: 5px;
        text-align: center;
    }
   
</style>