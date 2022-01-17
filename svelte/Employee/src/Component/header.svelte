<script>
export let header;
export let activeHeader;
import {createEventDispatcher} from 'svelte';

const dispatcher = createEventDispatcher();
</script>

    <div class='header'>
        <ul>
            {#each header as item}
            <li on:click={()=>dispatcher('headerchange',item)}>
                <div class:active={item === activeHeader}>{item}</div>
            </li>
            {/each}
        </ul>
    
    </div>

<style>
    .header{
        background: gray;
        width: 1850px;
        height: 50px;
        border-radius: 10px;
    }
ul{
    display: flex;
    justify-content: left;
    padding: 10px;
    list-style-type: none;
}
li{
    margin: 0 16px;
    font-size: 18px;
}
.active{
    color:white;
    border-bottom:  2px solid whitesmoke;
    padding-bottom: 8px;
}
</style>